param($installPath, $toolsPath, $package, $project)

$pcName = (Get-WmiObject -Class Win32_UserAccount -Filter "Name='$env:username' and Domain='$env:userdomain'").Name

if($pcName -ne "yks"){
	Start-Process "http://www.newbe.pro/"
	Start-Process "https://gitee.com/yks/Newbe.Mahua.Framework#project-donate-overview"
}

