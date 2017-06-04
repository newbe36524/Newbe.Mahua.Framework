Framework "4.6"

Task Default -depends CI 

Task CI -depends Build{

}
Task Nuget {
    .nuget/nuget.exe restore
}
Task Build -depends Nuget{
    msbuild 
}