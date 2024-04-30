## ManualWebServer
### Description
This project explores how to create a solution of two projects.
1. A Web Application project
2. A Service Library project.  

The setup will be done manually without the use of Visual Studio or any _Dotnet CLI_ template except for generating the solution file.  

### Setup
__Prerequisite__  
1. Dotnet SDK
2. Code Editor

__Step__
1. Create the solution
```bash
$ mkdir WebServer
$ cd WebServer
$ dotnet new sln
```
2. Create the Projects  
See [ManualWebApp/readme.md](../ManualWebApp/readme.md) on how to create a Web application manually.  
To create the Service Library, the major difference from the Web application is the _Sdk_ attribute of the project file which points to `Microsoft.NET.Sdk` unlike for Web application which points to `Microsoft.NET.Sdk.Web`.  

3. Add the projects to the solution
```bash
$ dotnet sln WebServer.sln add WebApp
$ dotnet sln WebServer.sln add ServiceLib
```
4. Build the solution  
Using _msbuild_  
```bash
$ msbuild  ManualWebServer.sln
```
Alternative, you can use dotnet to build the solution
```bash
$ dotnet build ManualWebServer.sln
```
5. Run the application
```bash
$ dotnet run --project WebApp/WebApp.csproj
```
Alternatively, you can run the application by running the project's _dll_ file produces after the build process.
```bash
$ dotnet WebApp/bin/Debug/net6.0/WebApp.dll
```
6. Test in the browser by going to http://localhost:5000
7. Publish the application
```bash
$ dotnet publish WebApp/WebApp.csproj --configuration Release --output publish
```
8. Deploy the application  
Copy the content of the publish directory to your host server.
