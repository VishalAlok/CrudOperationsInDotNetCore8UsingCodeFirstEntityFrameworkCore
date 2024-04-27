# CrudOperationsInDotNetCore8UsingCodeFirstEntityFrameworkCore

Introduction: 
Demonstration of how to create a .Net Core Web API and use Code first approach using Entity framework core and Swagger.
We will use Entity Framework core with a code-first approach to create the model classes and database.
Additionally, we will utilize Swagger, an inbuilt feature of .NET Core Web API, to simplify the request-response process.

STEPS::::::::::::::::::::::::::::
Creating a Project
 - Create a new project using Visual Studio 2022, selecting the ASP.NET Core Web API Core template. 
 - Uncheck the "Configure for HTTPS" option and proceeds with creating the project. 

Swagger Integration
- Run the project, and Swagger opens in his browser.
- Swagger provides a user-friendly interface to interact with the API endpoints.
- By default, Swagger displays the "Weather Forecast" GET API, allowing users to try it out and view default values.

 Adding Packages
 Add the following packages using the NuGet Package Manager: 
 Microsoft.EntityFrameworkCore  - Version should be in accordance with Framewok selected
 Microsoft.EntityFrameworkCore.Tools
 Microsoft.EntityFrameworkCore.SqlServer

Adding Model Classes
- Create a "Models" folder and adds a class named "Employee" inside it.
- The "Employee" class includes properties such as "EmployeeNumber", "EmployeeName","Department" and "IsActive" Etc.

Checking the packages
Double click on Solution name: It should show 'Package Reference' with Version'. It also Shows TaretFramework.

 Creating the DB Context Class
- Create a new class named "EmployeeContext" inside the "Models" folder.
- Inherit "EmployeeContext" class from the DBContext class. 
- Create a constructor that accepts DBContextOptions, and inherit it from base(options).
- Also add a DBSet for the "Employee" classand keep it public. 

 Adding Connection String
 Add a connection string to the appsettings.json file.
 Include the server name, database name, and authentication details. 
 "ConnectionStrings": {
  "CompanyDatabase": "server=VISHAL-PREDATOR; database:companyDB; Integrated Security: True; MultipleActiveResultSets=true"
}

 Registering DB Context in the IOC Container in Program.cs
 Register the DBContext in the built-in IOC container by modifying the program.cs file.
 Use the "builder.services.AddDbContext" method to register the "EmployeeContext" class with the DBContextOptions. 

 Creating the Database
 Use Entity Framework Core migration to create the database schema.
 Click 'Tools' on Visual Studio and select "NuGet Package Manager" and select "Package Manager Console".
 Run the "Add-Migration Initial" command in the Package Manager Console.
 This Command generates code to generate initial DB schema, Which will be based on the model written by us in EmployeeContext class .
 Solution explorer will now have a folder named Migrations with twio files. The initials file will show the table which is going to get created along with the names of the table schema acn constrains.
 
 Then, execute the  "Update-Database" command to create the database based on the migration script. 

 Creating API Endpoints
 Add a new controller named  "EmployeeController" to the project.
 Include the DBContext class in the controller and creates CRUD operations using HTTP GET, POST, PUT, and DELETE methods. 

 Testing the APIs
 Run the project and use Swagger to test the API endpoints.
 Try out the GET, POST, PUT, and DELETE methods and verify the results. 
