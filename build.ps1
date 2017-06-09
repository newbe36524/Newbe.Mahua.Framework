Framework "4.6"
Properties {
    $autoVersion = $true
}

Task Default -depends CI 

Task CI -depends NugetPack -Description  "持续集成" {

}
Task Nuget -Description  "Nuget还原" {
    Exec {
        .nuget/nuget.exe restore
    }
}
Task Build -depends Nuget -Description  "编译解决方案" {
    Exec {
        msbuild /p:Configuration=Release
    }
}
Task NugetPack -depends Build -Description  "生成Nuget包" {
    [string]$version = [System.IO.File]::ReadAllText((Get-ChildItem nuget.version))
    if ($autoVersion) {
        $v = New-Object System.Version($version)
        $versionNext = New-Object System.Version($v.Major, $v.Minor, ($v.Build + 1))
        [System.IO.File]::WriteAllText("nuget.version", $versionNext)
    }
    Exec {
        Get-ChildItem Nuspecs *.nuspec -File | ForEach-Object {
            .nuget/nuget.exe pack $_.FullName -Version $versionNext -OutputDirectory npks
        }
    }
}