## Manual WebApp
### Description
This project explores the task of creating a Dotnet web application without using _Visual Studio_ or any _Dotnet CLI_ template.
The only Prerequisites here is the _Dotnet SDK_ and any code editor.  
However, the _Dotnet CLI_ may only be used to install the needed package and run the application.  

### Setup
__Prerequite__  
1. Dotnet SDK
2. Code Editor

__Steps__
1. Create your project file, for example _MyWebApp.csproj_.  
2. Create a _Program.cs_ file.
3. Install the required _nuget packages_ that is specified or required by the project file
```bash
$ dotnet restore
```
4. Build the project using _msbuild_
```bash
$ msbuild MyWebApp.csproj  
```
5. Run the application
```bash
$ dotnet bin/Debug/net6.0/MyWebApp.dll
```
6. Test in the browser by going to http://localhost:5000

7. Publish the application  
```bash
$ dotnet publish --configuration Release --output ./publish
```
8. Deploy the application by copying the content of the _publish_ directory to your host server.  
