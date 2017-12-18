
..\packages\NuGet.CommandLine.4.3.0\tools\NuGet.exe install buildTools\packages.config -OutputDirectory ..\packages -Verbosity normal
powershell.exe -NoProfile -ExecutionPolicy unrestricted -Command "& {Import-Module '..\packages\psake.*\tools\psake.psm1';Import-Module '..\packages\Newbe.Build.Psake.1.0.6\tools\VSSetup\**\*.psd1';Import-Module '..\packages\Newbe.Build.Psake.1.0.6\tools\*.psm1'; invoke-psake .\build.ps1 %*; if ($LastExitCode -and $LastExitCode -ne 0) {write-host "ERROR CODE: $LastExitCode" -fore RED; exit $lastexitcode} }"
