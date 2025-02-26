# CSharpNet8Login

## Create project
ASP,Net Core Web App (Model-View-Controller)

https://www.youtube.com/watch?v=712G-iQ1zzg
How to create Custom Login Registration in Asp.Net MVC (.Net 8 | Code First)


## Add NuGet Packages
Navigate to the project folder
```bash
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
dotnet add package Microsoft.EntityFrameworkCore.Tools
```

## Create Database
```bash
Add-Migration Initial
Update-database
``` 

## Drop DB
Delete Migrations folder
then:
```bash
Drop-Database
Drop-Database -Force
```