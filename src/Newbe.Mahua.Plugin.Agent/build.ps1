Framework "4.6x86"
properties {
    $rootNow = Resolve-Path .
    $configuration = "Debug"
    $releaseBase = "$rootNow\bin"
    $fwVersion = "net461"
    $currentBuild = "$releaseBase\$configuration\$fwVersion"
    $pluginName = (Get-ChildItem *.csproj).Name.Replace(".csproj", "")
    $nugetexe = "$rootNow\buildTools\nuget.exe"
    $version = "2.4"
}

$platforms = @(
"Newbe.Mahua.CQP",
"Newbe.Mahua.MPQ",
"Newbe.Mahua.QQLight"
)

Task Default -depends Pack

Task Clean -Description "清理" {
    $platforms | ForEach-Object {
        Exec {
            $platformName = $_.Split('.')[2]
            Remove-Item "$releaseBase\$platformName" -Recurse -Force -ErrorAction SilentlyContinue
        }
    }
}

Task Init -depends Clean -Description "初始化参数" {

}

Task Nuget -depends Init -Description "nuget restore" {
    Exec {
        dotnet restore
    }
}

Task Build -depends Nuget -Description "编译" {
    Exec {
        msbuild /m
    }
}

Task PackCQP -depends Clean -Description "CQP打包" {
    Exec {
        # CQP 要求 dll 名称和 appid 要相同，并且为小写
        $cqpDevPluginDirName = $pluginName.ToLowerInvariant()
        New-Item -ItemType Directory "$releaseBase\CQP"
        New-Item -ItemType Directory "$releaseBase\CQP\$pluginName"
        New-Item -ItemType Directory "$releaseBase\CQP\dev\$cqpDevPluginDirName"
        # 复制平台对应实现
        Copy-Item "../Newbe.Mahua.CQP/bin/$configuration/$fwVersion/*" "$releaseBase/CQP" -Recurse
        # 插件运行时
        Copy-Item -Path "$currentBuild\*", "../Newbe.Mahua.CQP/bin/$configuration/$fwVersion/*" -Destination "$releaseBase\CQP\$pluginName" -Recurse
        # 机器人平台入口文件
        Copy-Item -Path "../Newbe.Mahua.CQP.Native/bin/$configuration/x86/Newbe.Mahua.CQP.Native.dll" -Destination  "$releaseBase\CQP\dev\$cqpDevPluginDirName\app.dll"
        # 复制配置文件
        Copy-Item -Path "Configs/*" "$releaseBase/CQP" -Recurse
        # CQP.json
        Copy-Item Newbe.Mahua.Plugin.Agent.json "$releaseBase\CQP\dev\$cqpDevPluginDirName\app.json"
    }
}

Task PackQQLight -depends  Clean -Description "QQLight打包" {
    Exec {
        New-Item -ItemType Directory "$releaseBase\QQLight"
        New-Item -ItemType Directory "$releaseBase\QQLight\$pluginName"
        New-Item -ItemType Directory "$releaseBase\QQLight\plugin"
        # 复制平台对应实现
        Copy-Item "../Newbe.Mahua.QQLight/bin/$configuration/$fwVersion/*" "$releaseBase/QQLight" -Recurse
        # 插件运行时
        Copy-Item -Path "$currentBuild\*", "../Newbe.Mahua.QQLight/bin/$configuration/$fwVersion/*" -Destination "$releaseBase\QQLight\$pluginName" -Recurse
        # 机器人平台入口文件
        Copy-Item -Path "../Newbe.Mahua.QQLight.Native/bin/$configuration/x86/Newbe.Mahua.QQLight.Native.dll" -Destination  "$releaseBase\QQLight\plugin\$pluginName.ql.dll"
        # 复制配置文件
        Copy-Item -Path "Configs/*" "$releaseBase/QQLight" -Recurse
    }
}

Task PackMPQ -depends  Clean -Description "MPQ打包" {
    Exec {
        New-Item -ItemType Directory "$releaseBase\MPQ"
        New-Item -ItemType Directory "$releaseBase\MPQ\$pluginName"
        New-Item -ItemType Directory "$releaseBase\MPQ\Plugin"
        # 复制平台对应实现
        Copy-Item "../Newbe.Mahua.MPQ/bin/$configuration/$fwVersion/*" "$releaseBase/MPQ" -Recurse
        # 插件运行时
        Copy-Item -Path "$currentBuild\*", "../Newbe.Mahua.MPQ/bin/$configuration/$fwVersion/*" -Destination "$releaseBase\MPQ\$pluginName" -Recurse
        # 机器人平台入口文件
        Copy-Item -Path "../Newbe.Mahua.MPQ.Native/bin/$configuration/x86/Newbe.Mahua.MPQ.Native.dll" -Destination  "$releaseBase\MPQ\Plugin\$pluginName.xx.dll"
        # 复制配置文件
        Copy-Item -Path "Configs/*" "$releaseBase/MPQ" -Recurse
    }
}

Task Pack -depends PackCQP, PackMPQ, PackQQLight -Description "打包" {
    Write-Output "构建完毕，当前时间为 $( Get-Date )"
}

Task PackNuget -depends Pack -description "创建nuget包" {
    $platforms | ForEach-Object {
        Exec {
            $platformName = $_.Split('.')[2]
            Get-ChildItem "$releaseBase\$platformName" -Recurse -File | Select-Object -Property FullName | ForEach-Object { return $_.FullName.Replace("$releaseBase\$platformName\","") } | ConvertTo-Json | Out-File "$releaseBase\$platformName\mahua.files.json" 
            Copy-Item "Nuspec/Newbe.Mahua.$platformName.Asset.nuspec" "$releaseBase\$platformName"
            . $nugetexe pack $releaseBase\$platformName\Newbe.Mahua.$platformName.Asset.nuspec -OutputDirectory ../build -Version $version -Verbosity quiet
        }
    }
}