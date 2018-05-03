# run in nuget package console
"Newbe.Mahua.CQP.Native","Newbe.Mahua.Amanda.Native","Newbe.Mahua.MPQ.Native" | ForEach-Object { update-package -reinstall -projectName $_ }