Framework "4.6"
properties {
    $rootNow = Resolve-Path .
    $nugetexe = "$rootNow\..\packages\NuGet.CommandLine.4.3.0\tools\NuGet.exe"
    $configuration = "Release"
    $releaseBase = "$rootNow\bin"
    $pluginName = (Get-ChildItem *.csproj).Name.Replace(".csproj", "")
}

$InstalledPlatforms = Get-ChildItem NewbeLibs\Platform

function Copy-FrameworkItems ($dest) {
    Write-Output "开始复制-框架主体"
    Get-ChildItem "$rootNow\NewbeLibs\Framework\" |
        Where-Object {
        $_.PsIsContainer -eq $false
    } |
        ForEach-Object {
        Copy-Item -Path  "$rootNow\NewbeLibs\Framework\$_" -Destination $dest
    }
    Write-Output "结束复制-框架主体"
}

function Copy-FrameworkExtensionItems ($dest) {
    Write-Output "开始复制-框架扩展"
    Get-ChildItem "$rootNow\NewbeLibs\Framework\Extensions\" |
        ForEach-Object {
        Copy-Item -Path  "$rootNow\NewbeLibs\Framework\Extensions\$_\*" -Destination $dest -Recurse
    }
    Write-Output "结束复制-框架扩展"
}

Task Default -depends Pack

Task Clean -Description "清理" {
    Write-Output $InstalledPlatforms
    $InstalledPlatforms | ForEach-Object {
        Exec {
            Remove-Item "$releaseBase\$_" -Recurse -Force -ErrorAction SilentlyContinue
        }
    }
}

Task Init -depends Clean -Description "初始化参数" {
	Initialize-MSBuild
}

Task Nuget -depends Init -Description "nuget restore" {
    Exec {
        cmd /c ""$nugetexe" restore  -PackagesDirectory $rootNow\..\packages"
    }
}

Task Build -depends Nuget -Description "编译" {
    Exec {
        msbuild /p:Configuration=$configuration
    }
}
Task PackCQP -depends Build -Description "CQP打包" {
    if ($InstalledPlatforms | Where-Object {$_.Name -eq "CQP"}) {
        New-Item -ItemType Directory "$releaseBase\CQP"
        New-Item -ItemType Directory "$releaseBase\CQP\$pluginName"
        New-Item -ItemType Directory "$releaseBase\CQP\app"
        Copy-FrameworkItems -dest "$releaseBase\CQP\"
        Copy-Item -Path  "$rootNow\NewbeLibs\Platform\CQP\CLR\*" -Destination "$releaseBase\CQP" -Recurse
        Copy-FrameworkExtensionItems -dest "$releaseBase\CQP\$pluginName"
        Copy-Item -Path "$releaseBase\$configuration\*", "$rootNow\NewbeLibs\Platform\CQP\CLR\*"   -Destination "$releaseBase\CQP\$pluginName" -Recurse
        Copy-Item -Path "$rootNow\NewbeLibs\Platform\CQP\Native\Newbe.Mahua.CQP.Native.dll" -Destination  "$releaseBase\CQP\app\$pluginName.dll"
        Copy-Item -Path "$rootNow\NewbeLibs\Platform\CQP\Content\Newbe.Mahua.CQP.json" -Destination  "$releaseBase\CQP\app\$pluginName.json"
    }
}

Task PackAmanda -depends Build -Description "Amanda打包" {
    if ($InstalledPlatforms | Where-Object {$_.Name -eq "Amanda"}) {
        New-Item -ItemType Directory "$releaseBase\Amanda"
        New-Item -ItemType Directory "$releaseBase\Amanda\$pluginName"
        New-Item -ItemType Directory "$releaseBase\Amanda\plugin"
        Copy-FrameworkItems -dest "$releaseBase\Amanda\"
        Copy-Item -Path  "$rootNow\NewbeLibs\Platform\Amanda\CLR\*" -Destination "$releaseBase\Amanda" -Recurse
        Copy-FrameworkExtensionItems -dest "$releaseBase\Amanda\$pluginName"
        Copy-Item -Path "$releaseBase\$configuration\*", "$rootNow\NewbeLibs\Platform\Amanda\CLR\*"   -Destination "$releaseBase\Amanda\$pluginName" -Recurse
        Copy-Item -Path "$rootNow\NewbeLibs\Platform\Amanda\Native\Newbe.Mahua.Amanda.Native.dll" -Destination  "$releaseBase\Amanda\plugin\$pluginName.plugin.dll"
    }
}

Task PackMPQ -depends Build -Description "MPQ打包" {
    if ($InstalledPlatforms | Where-Object {$_.Name -eq "MPQ"}) {
        New-Item -ItemType Directory "$releaseBase\MPQ"
        New-Item -ItemType Directory "$releaseBase\MPQ\$pluginName"
        New-Item -ItemType Directory "$releaseBase\MPQ\Plugin"
        Copy-FrameworkItems -dest "$releaseBase\MPQ\"
        Copy-Item -Path  "$rootNow\NewbeLibs\Platform\MPQ\CLR\*" -Destination "$releaseBase\MPQ" -Recurse
        Copy-FrameworkExtensionItems -dest "$releaseBase\MPQ\$pluginName"
        Copy-Item -Path "$releaseBase\$configuration\*", "$rootNow\NewbeLibs\Platform\MPQ\CLR\*"   -Destination "$releaseBase\MPQ\$pluginName" -Recurse
        Copy-Item -Path "$rootNow\NewbeLibs\Platform\MPQ\Native\Newbe.Mahua.MPQ.Native.dll" -Destination  "$releaseBase\MPQ\Plugin\$pluginName.xx.dll"
    }
}

Task Pack -depends PackCQP, PackAmanda, PackMPQ -Description "打包"

