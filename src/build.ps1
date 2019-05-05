Framework 4.6
properties {
    $rootNow = Resolve-Path .
    $deployMode = "Debug"
    $releaseDir = "$rootNow\build\"
    $nugetexe = "$rootNow/buildTools/nuget.exe"
}

Task Default -depends NugetPushLocal

Task Clean -Description "清理上一次编译结果" {
    Remove-Item $releaseDir -Force -Recurse -ErrorAction SilentlyContinue
}

Task Init -depends Clean -Description "初始化参数" {
    New-Item build -ItemType Directory -ErrorAction SilentlyContinue
}

Task Nuget -depends Init -Description "nuget restore" {
    Exec {
        dotnet restore Newbe.Mahua.sln
    }
    Exec {
        . $nugetexe restore Newbe.Mahua.sln
    }
}

Task Build -depends Nuget -Description "编译所有解决方案" {
    Exec {
        msbuild /m /t:"Build" /p:Configuration=$deployMode /v:minimal /nologo  Newbe.Mahua.Native.sln
    }
    Exec {
        msbuild /m /t:"Build" /p:Configuration=$deployMode /v:minimal /nologo  Newbe.Mahua.sln
    }
}
Task Pack -depends Build -Description "打包" {
    Exec {
        dotnet pack Newbe.Mahua.Pack.sln -c $deployMode --no-build --disable-parallel
    }
}
Task NugetPushLocal -depends Pack -Description "推送nuget包到本地" {
    Write-Output "构建完毕，当前时间为 $(Get-Date)"
}

Task NugetPushNuget -depends Pack -Description "推送nuget包到nuget.org" {
    Get-ChildItem $releaseDir *.nupkg | ForEach-Object {
        Exec {
            dotnet nuget push "$releaseDir$_" -s https://www.nuget.org/
        }
    }
    Write-Output "构建完毕，当前时间为 $(Get-Date)"
}

Task PackTemplate -depends Init -Description "打包项目模板" {
    $tpls = @(
        "Newbe.Mahua.Plugins.Template",
        "Newbe.Mahua.Plugins.Template.CleverQQ",
        "Newbe.Mahua.Plugins.Template.CQP",
        "Newbe.Mahua.Plugins.Template.MPQ",
        "Newbe.Mahua.Plugins.Template.QQLight"
    )

    $tpls | ForEach-Object {
        Remove-Item .\Newbe.Mahua.Template\$_\ItemTemplate -Recurse -Force -ErrorAction SilentlyContinue
        New-Item .\Newbe.Mahua.Template\$_\ItemTemplate -ItemType Directory
        Copy-Item .\Newbe.Mahua.Template\ItemTemplate\* .\Newbe.Mahua.Template\$_\ItemTemplate  -Recurse -Force
    }
    Exec {
        . $nugetexe pack "Newbe.Mahua.Template\Newbe.Mahua.Template.nuspec" -OutputDirectory $releaseDir
    }
    $tpls | ForEach-Object {
        Remove-Item .\Newbe.Mahua.Template\$_\ItemTemplate -Recurse -Force -ErrorAction SilentlyContinue
    }
}

Task TestTemplate -depends PackTemplate -Description "测试项目模板可用性" {
    # 安装模板
    Get-ChildItem $releaseDir Newbe.Mahua.Template.*.nupkg | ForEach-Object {
        Exec {
            dotnet new -i $releaseDir$_
        }
    }

    $tempDir = "$($env:TEMP)\Newbe\Newbe.Mahua\tplTest"

    Remove-Item $tempDir -Recurse -Force -ErrorAction SilentlyContinue
    New-Item $tempDir -ItemType Directory

    $tpls = @(
        "newbe.mahua.all",
        "newbe.mahua.cleverqq",
        "newbe.mahua.cqp",
        "newbe.mahua.mpq",
        "newbe.mahua.qqlight"
    )

    $tpls | ForEach-Object {
        Exec {
            New-Item  "$tempDir\$_" -ItemType Directory
            dotnet new $_ -o "$tempDir\$_" -n "$_.plugins"
        }
    }
}

Task PushTemplate -depends PackTemplate -Description "推送项目模板" {
    Get-ChildItem $releaseDir *.nupkg | ForEach-Object {
        Exec {
            dotnet nuget push "$releaseDir$_" -s https://www.nuget.org/
        }
    }
}

Task ReconfigDllExport -description "初始化DllExport" {
    Exec {
        .\DllExport.bat  -action Restore -sln-file Newbe.Mahua.sln
    }
}