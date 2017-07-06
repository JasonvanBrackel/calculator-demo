# Bypass execution policy
Set-ExecutionPolicy -ExecutionPolicy Bypass -Scope Process

# Install Chocolatey
Invoke-Expression ((New-Object System.Net.WebClient).DownloadString('https://chocolatey.org/install.ps1'))