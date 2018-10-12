# C# project boilerplate

## Includes
* Unit Testing - xUnit
* Code coverage - coverlet
* Report generator

## Basic Commands
Before usage execute
```
$ dotnet recover
```
```
$ dotnet build
$ dotnet run App
$ dotnet msbuild -t:TestTarget

```
## Tests
Run specific test
```
$ dotnet test Tests/App.Tests
```

Run all tests
```
$ dotnet msbuild App -t:UnitTest
```

Generate xml coverage in "reports" directory
```
$ dotnet msbuild App -t:Coverage
```

Generate html report in "reports" directory
```
$ dotnet msbuild App -t:Report
```
