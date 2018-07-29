param($installPath, $toolsPath, $package, $project)

$pcName = (Get-WmiObject -Class Win32_UserAccount -Filter "Name='$env:username' and Domain='$env:userdomain'").Name