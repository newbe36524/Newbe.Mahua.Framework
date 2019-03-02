Framework 4.6
properties {
    $rootNow = Resolve-Path .
    $nugetexe = "$rootNow/buildTools/nuget.exe"
    $mahuaDownloadTempDir = "$( $env:TEMP )\Newbe\Newbe.Mahua\Mahua2.Asset"
    $mahuaFilesJson = "mahua.files.json"
}

function Get-PlartformName
{
    if ((Test-Path "$rootNow/CQA.exe") -or (Test-Path "$rootNow/CQP.exe"))
    {
        return "CQP"
    }
    if (Test-Path "$rootNow/Core.exe")
    {
        return "MPQ"
    }
    if ((Test-Path "$rootNow/CleverQQ Pro.exe") -or (Test-Path "$rootNow/CleverQQ Air.exe"))
    {
        return "CleverQQ"
    }
    if (Test-Path "$rootNow/QQLight.exe")
    {
        return "QQLight"
    }
    return "Unknow"
}

Task Default -depends DisplayCurrentPlatform

Task DisplayCurrentPlatform -description "display current platform name"{
    $plartform = Get-PlartformName
    if ($plartform -eq "Unknow")
    {
         throw "无法检测出当前所使用的机器人平台。请仔细按照说明将安装文件放置正确的文件夹。"
    }
    Write-Host "current platform is $plartform"
}

Task Init -depends DisplayCurrentPlatform {

}

Task DownloadNuget -description "donwload nuget.exe" {
    if (-not(Test-Path $nugetexe))
    {
        New-Item buildTools -ItemType Directory -ErrorAction SilentlyContinue
        Invoke-WebRequest https://dist.nuget.org/win-x86-commandline/latest/nuget.exe -OutFile $nugetexe
    }
}

Task InstallMahua -depends RemoveMahua, DownloadNuget, Init -Description "install Newbe.Mahua" {
    $plartform = Get-PlartformName
    Remove-Item $mahuaDownloadTempDir -Force -Recurse -ErrorAction SilentlyContinue
    New-Item $mahuaDownloadTempDir -ItemType Directory -ErrorAction SilentlyContinue
    . $nugetexe install "Newbe.Mahua.$plartform.Asset" -OutputDirectory $mahuaDownloadTempDir -ExcludeVersion
    Copy-Item "$mahuaDownloadTempDir\Newbe.Mahua.$plartform.Asset\*" . -Recurse -Force
    # remove nupkg copied from temp
    Remove-Item "$rootNow\Newbe.Mahua.$plartform.Asset.nupkg" -Force -ErrorAction SilentlyContinue
    Write-Host "Newbe.Mahua installed success."
}

Task RemoveMahua -Description "remove Newbe.Mahua" {
    if (Test-Path $mahuaFilesJson)
    {
        $files = Get-Content $mahuaFilesJson -Encoding UTF8 | ConvertFrom-Json
        $files | ForEach-Object {
            if ($_ -ne $mahuaFilesJson)
            {
                $file = "$rootNow/$_"
                if (Test-Path $file)
                {
                    Remove-Item $file
                    Write-Host "$file removed"
                }
            }
        }
        Remove-Item $rootNow/$mahuaFilesJson
        Write-Host "$rootNow/$mahuaFilesJson removed"
    }
    else
    {
        Write-Host "$mahuaFilesJson is not exsistd , expected Newbe.Mahua is not installed"
    }
}