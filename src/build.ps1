Framework "4.6"
properties {
    $rootNow = Resolve-Path .
    $nugetexe = "$rootNow\packages\NuGet.CommandLine.4.3.0\tools\NuGet.exe"
    $deployMode = "Release"
    $releaseDir = "$rootNow\build\"
}

Task Default -depends Build

Task Clean -Description "清理上一次编译结果" {
    Remove-Item $releaseDir -Force -Recurse -ErrorAction SilentlyContinue
}

Task Init -depends Clean -Description "初始化参数" {
    Initialize-MSBuild
}

Task Nuget -depends Init -Description "nuget restore" {
    NugetRestoreAll -nugetexe $nugetexe
}

Task Build -depends Nuget -Description "编译所有解决方案" {
    RebuildAllSln -deployMode $deployMode
}

Task NugetPushLocal -depends Build -Description "推送nuget包到本地" {
    Get-ChildItem $releaseDir *.nupkg | ForEach-Object { 
        Exec {
            $s = "$nugetexe push $releaseDir$_ Admin:Admin -Source http://localhost:81/nuget/NewbeGet/"
            Write-Output $s
            cmd /c "$s"
        }
    }
}