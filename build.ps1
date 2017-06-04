
Task Default -depends CI

Task CI -depends Build{

}
Task Nuget {
    .nuget/nuget.exe restore
}
Task Build -depends Nuget{
    msbuild /m
}