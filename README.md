# Auth-Funcs
Auth-Funcs implements basic authentication functionalities with use of Azure, ASP.NET and ReactJS.

# Auth-Funcs-API
Auth-Funcs-API is a repository for API service written in ASP.NET Core (.NET 6). 
For Notifications Auth-Funcs-API runs a _BackgroundService_ that inserts messages to `Azure Service Bus` which are later received by Auth-Funcs-MQ service. 
Data is stored on `Azure SQL Server`. 
https://github.com/P3piK/Auth-Funcs-API

# Auth-Funcs-MQ
Auth-Funcs-MQ is a repository of Auth-Funcs Notification Service. 
The App utilizes `Azure Service Bus` to receive messages from API-Project which converts into _EmailMessage_'s and sends utilizing `Azure Communication Services`.
`Azure WebJobs` allow Auth-Funcs-MQ to run as a _Background Service_ for the API process.
https://github.com/P3piK/Auth-Funcs-MQ

# Auth-Funcs-UI
Auth-Funcs-UI is a repository containing ReactJS front-end code. Currently some pre-alpha stage... 
https://github.com/P3piK/Auth-Funcs-UI

# Demo
AuthFuncs API is available on https://authfuncsapi.azurewebsites.net/swagger/index.html
