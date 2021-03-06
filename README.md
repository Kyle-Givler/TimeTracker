# Time Tracker
This project allows tracking the amount of time spent on projects.

Categories and subcategories can be used to organize projects. Entries can then be added to these projects. The total time spent on all projects can then be tracked, along with the amount of time spent per project, category and subcategory.

I am currently seeking employment as a developer.
This project shows my ability to understand, work with, and implement the following:


C#

Winforms

SQL Server

Dapper

Separate Core logic from the UI into a library

Use NuGet packages

Dependency Injection

Please feel free to contact me if interested in talking about this project, C#, or employment opportunities. Thanks for reading!

Kyle Givler - https://www.linkedin.com/in/kyle-givler/

# Time Tracker Notes:
This program will automatically (re-)create the SQLite database if it does not exist. 

Unfortunately automatically creating the database turned out to be harder than I expected for SQL Server using Dapper. Due to this the database will not be created automatically. Therefore, if using the SQL Server database option I would recommend publishing the database from the SQL Server database project in the solution. Another option is using the provided script (TimeTrackerDB.sql) after checking to see if any modification are needed for your setup. For SQL Server the connection string will need to be modified in appsettings.json.

The default database is SQLite. Valid settings for "DatabaseType" in appsettings.json are SQLite and MSSQL. 

I would love to hear any suggestion on how to automatically  create the database, tables and stored procedure if they do not already exists for SQL Server using Dapper.