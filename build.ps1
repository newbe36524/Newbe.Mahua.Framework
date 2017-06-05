Framework "4.6"
Properties {
    $nugetPackVersion = "1.0.0"
}

Task Default -depends CI 

Task CI -depends NugetPack -Desciption "持续集成" {

}
Task Nuget -Desciption "Nuget还原" {
    .nuget/nuget.exe restore
}
Task Build -depends Nuget -Desciption "编译解决方案" {
    msbuild /p:Configuration=Release
}
Task NugetPack -depends Build -Desciption "生成Nuget包" {
    Get-ChildItem Nuspecs *.nuspec -File | ForEach-Object {
        .nuget/nuget.exe pack $_.FullName -Version $nugetPackVersion -OutputDirectory npks
    }
}