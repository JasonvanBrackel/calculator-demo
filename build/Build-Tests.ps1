$ErrorActionPreference = 'Stop'
nuget restore ./src/CalculatorDemo.sln

Write-Host "Building Tests"
dotnet build ./src/test/test.csproj