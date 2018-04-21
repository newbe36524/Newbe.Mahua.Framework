Framework "4.6"
properties {
    $rootNow = Resolve-Path .
    $nugetexe = "$rootNow\packages\NuGet.CommandLine.4.3.0\tools\NuGet.exe"
    $deployMode = "Debug"
    $releaseDir = "$rootNow\build\"
}

Task Default -depends NugetPushLocal

Task Clean -Description "清理上一次编译结果" {
    Remove-Item $releaseDir -Force -Recurse -ErrorAction SilentlyContinue
}

Task Init -depends Clean -Description "初始化参数" {
    Initialize-MSBuild
}

Task Nuget -depends Init -Description "nuget restore" {
    dotnet restore Newbe.Mahua.sln
}

Task Build -depends Nuget -Description "编译所有解决方案" {
    Exec {
        msbuild /m /t:"Clean;Rebuild" /p:Configuration=$deployMode /v:minimal /nologo  Newbe.Mahua.sln
    }
}
Task Pack -depends Build -Description "打包" {
    $packList = @(
        "Newbe.Mahua",
        "Newbe.Mahua.PluginLoader",
        "Newbe.Mahua.Tools.Psake",
        "Newbe.Mahua.Administration",
        "Newbe.Mahua.Amanda",
        "Newbe.Mahua.CQP",
        "Newbe.Mahua.MPQ",
        "Newbe.Mahua.CQP.ApiExtensions"
    )
    $packList | ForEach-Object {
        Exec {
            dotnet pack "$_\$_.csproj" -c $deployMode --no-build
        }
    }
}
Task NugetPushLocal -depends Pack -Description "推送nuget包到本地" {
    Get-ChildItem $releaseDir *.nupkg | ForEach-Object {
        Exec {
            cmd /c "$nugetexe push $releaseDir$_ -Source http://localhost:28081/repository/nuget-hosted/"
        }
    }
}

Task NugetPushNuget -depends Pack -Description "推送nuget包到nuget.org" {
    Get-ChildItem $releaseDir *.nupkg | ForEach-Object {
        cmd /c "$nugetexe push $releaseDir$_ -Source https://www.nuget.org/api/v2/package"
    }
}