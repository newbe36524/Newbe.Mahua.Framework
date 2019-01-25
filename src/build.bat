@echo off
%~d0
cd %~dp0
powershell.exe -NoProfile -ExecutionPolicy unrestricted -Command "& {if(-not (Get-Module -ListAvailable  VSSetup)){Install-PackageProvider -Name NuGet -MinimumVersion 2.8.5.201 -Force -Scope CurrentUser;Install-Module -Name VSSetup -Scope CurrentUser -Force;}if(-not (Get-Module -ListAvailable  psake)){Install-Module -Name psake -RequiredVersion 4.7.4 -Scope CurrentUser -Force;} invoke-psake .\build.ps1 %*; if ($global:lastexitcode -and $global:lastexitcode -ne 0) {write-host "ERROR CODE: $global:lastexitcode" -fore RED; exit $global:lastexitcode} }"
