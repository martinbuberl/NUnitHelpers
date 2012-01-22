Get-ChildItem . -recurse -force -include *.suo,*.user,*.cache,*.docstates,bin,obj,build,_ReSharper.* | foreach -process {Remove-Item $_.FullName -Force -Recurse}

Write-Host "Press any key to continue . . ."
$x = $host.UI.RawUI.ReadKey("NoEcho,IncludeKeyDown")