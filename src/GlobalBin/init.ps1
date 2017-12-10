param($installPath, $toolsPath, $package, $project)

$pcName = (Get-WmiObject -Class Win32_UserAccount -Filter "Name='$env:username' and Domain='$env:userdomain'").Name

if($pcName -ne "yks"){
	Start-Process "http://www.newbe.cf/"
	Start-Process "https://jq.qq.com/?_wv=1027&k=4AMMCTx"
	Start-Process "https://github.com/Newbe36524/Newbe.Mahua.Framework"
	Start-Process "http://git.oschina.net/yks/Newbe.Mahua.Framework"
}

