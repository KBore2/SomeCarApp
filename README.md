# Some Car App #

### What is this repository for? ###

Some car app is used to explain DDD concepts

### Solution Structure ###
***SomeCarApp***

*A .NET 6.0 API that allows you to create cars and brands and query them.*

***SomeCarApp.Commands***

*A .NET 6.0 class library that handles the commands sent to the car application.*

***SomeCarApp.Queries***

*A .NET 6.0 class library that handles the queries sent to the car application.*

***SomeCarApp.Domain***

*A .NET 6.0 class library that handles the domain logic for the car application.*

***SomeCarApp.Infrastructure***

*A .NET 6.0 class library that handles the infrastructure intergrations of the car application.*

### How do I get set up? ###

If you wish to use https to run the application (which is preffered) you can run the following commands to achieve this:

```

dotnet dev-certs https -ep $env:USERPROFILE\.aspnet\https\aspnetapp.pfx -p p@ssword
dotnet dev-certs https --trust
```

#### Configuration ####
Set the database connection string in the `ConnectionStrings__CarsDB` configuration propperty.

#### Docker ####

You will require the Docker and Docker Compose to start the services if you wish to use Docker.
You can use the following command to start up the service from the root directory:

**SomeCarApp**

```
 docker-compose build 
 docker-compose up -d
```

#### Database Migrations####

Run the Database migrations after configuring the conneciton string to stand up the database schema.

```
cd .\SomeCarApp\
dotnet ef database update
```
#### Dependencies ####

* Microsoft SQL Server
