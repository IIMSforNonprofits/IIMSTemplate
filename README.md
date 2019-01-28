# Mahenta Setup -
##### ***more thorough explanations to be added***
In terminal -
```
npm i
```
In Visual Studio -
Right click on Solution and select restore packages. If that doesn't work, do the below steps:

In Package Manager Console in VS -
```
Install-Package React.AspNet
Install-Package React.Router
```
Rebuild to find any left over 

### Setting up SQL Dbs

Currently, this application uses User Secrets so it is up to you to determine your connection strings.

After User Secrets is set up, run the following in the Package Manager Console in Visual Studio -
```
Update-Database -Context ApplicationDbContext
Update-Database -Context InvMgmtDbContext
```

### After dealing with dependencies -
Ensure that your project's local host is set to 9456
* Right click on Solution > Properties
* Go to Debug tab
* change localhost/12345 to localhost/9456