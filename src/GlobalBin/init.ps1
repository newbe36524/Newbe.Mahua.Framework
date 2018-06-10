param($installPath, $toolsPath, $package, $project)

$pcName = (Get-WmiObject -Class Win32_UserAccount -Filter "Name='$env:username' and Domain='$env:userdomain'").Name

if($pcName -ne "yks"){
	Start-Process "http://www.newbe.pro/"
	Start-Process "https://github.com/Newbe36524/Newbe.Mahua.Framework/issues/36"
	Start-Process "https://github.com/Newbe36524/Newbe.Mahua.Framework/issues/37"
}

