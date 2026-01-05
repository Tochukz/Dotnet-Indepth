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

### Running Old Dotnet Projects
Sometimes you may have to run a Dotnet project written long ago for an old Dotnet framework version.  
Let's say the current Dotnet version is 10 and you have to maintain a Web App that was written for version 8.   
There are two possible line of actions
* Upgrade the application to use the latest version
* Continue using the origin version.

Here we want to continue with the original version, so we need to do the following to proceed:

1. __Check the target version__  
Go to the `csproj` file and check the `TargetFrameWork`.
2. __Install the target dotnet framework SDK__  
First check if you have the target dotnet SDK installed on your machine
```bash
$ dotnet --list-sdks
```
If you don't have the target version, you must install it.
3. __Download and install the SDK target version__ 
  - Go to [Download .NET](dotnet.microsoft.com/en-us/download/dotnet), look for the target version,
  - Download and install the SDK version.
  - After successful installation,  `dotnet --list-sdks` command should show the installed SDK version.  

## SQL Server
__Install sqlcmd on MacOS__   
```
$ /bin/bash -c "$(curl -fsSL https://raw.githubusercontent.com/Homebrew/install/HEAD/install.sh)"
$ brew install sqlcmd
$ sqlcmd --version
```
