Get-ChildItem *.nuspec | ForEach-Object { nuget pack $_ -OutputDirectory packages }