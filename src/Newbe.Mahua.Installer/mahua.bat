@echo off
%~d0
cd %~dp0
powershell -NoProfile -NonInteractive -ExecutionPolicy unrestricted -Command "& {import-module .\buildScripts\psake\4.8.0\psake.psd1;invoke-psake .\mahua.ps1 %*; if ($global:lastexitcode -and $global:lastexitcode -ne 0) {write-host "ERROR CODE: $global:lastexitcode" -fore RED; exit $global:lastexitcode} }"