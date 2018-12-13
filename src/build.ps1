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
    Exec{
        dotnet restore Newbe.Mahua.sln
    }
    Exec{
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