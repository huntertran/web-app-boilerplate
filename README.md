# web-app-boilerplate
A boilerplate for web-app with .net. No front-end

### How to create?
Run `dotnet new`

### Setup Database
1. SQLite
`dotnet add package Microsoft.EntityFrameworkCore.Sqlite --version 9.0.9`

### Run the project
#### Before run
1. Create database
`dotnet-ef database update`
2. If changes in models or DbContext files

Create new migration
`dotnet-ef migrations add migration_name`

Update database
`dotnet-ef database update`