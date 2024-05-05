# Dotnet Indepth
## Description
Here I explore the C# langauge and the Dotnet framework  fundamentals.  

## Basic Operations
__MS Build Operations__  

Operation        | Command
-----------------|------
Build a project  | `msbuild MyProject.csproj`
Build a solution | `msbuild MySolution.sln`

__Dotnet Operation__  

Operation          | Command
-------------------|--------
List all templates | `dotnet new list`
Create a project   | `dotnet new web --output EmptyWebApp`
Build a project    | `dotnet build MyProject.csproj`
Build a solution   | `dotnet build MySolution.sln`
Run Web App        | `dotnet run`
Run Web hot reload | `dotnet watch run`

## SQL Server
__Install sqlcmd on MacOS__   
```
$ /bin/bash -c "$(curl -fsSL https://raw.githubusercontent.com/Homebrew/install/HEAD/install.sh)"
$ brew install sqlcmd
$ sqlcmd --version
```
