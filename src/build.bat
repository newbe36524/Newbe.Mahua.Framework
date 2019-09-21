@echo off
%~d0
cd %~dp0
powershell -NoProfile -NonInteractive -ExecutionPolicy unrestricted -Command "& {import-module .\buildScripts\psake\4.8.0\psake.psd1;import-module .\buildScripts\VSSetup\2.2.5\VSSetup.psd1;invoke-psake .\build.ps1 %*; if ($global:lastexitcode -and $global:lastexitcode -ne 0) {write-host "ERROR CODE: $global:lastexitcode" -fore RED; exit $global:lastexitcode} }"