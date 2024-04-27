using CrudOperationsInDotNetCore8.Models;
using Microsoft.EntityFrameworkCore;

namespace CrudOperationsInDotNetCore8
{
    public class Program
    {
        /// The Main method is the entry point for the application.
        public static void Main(string[] args)
        {
            // Create a new web application builder with the provided command-line arguments.
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            // Configure the DbContext for the EmployeeContext.
            // This sets up the DbContext to use a SQL Server database with the connection string named "CompanyDatabase" from the application's configuration settings.
            builder.Services.AddDbContext<EmployeeContext>(options =>
            options.UseSqlServer(builder.Configuration.GetConnectionString("CompanyDatabase")));

            // Add controllers as services so they can be injected.
            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            // Add API explorer services which are required for Swagger.
            builder.Services.AddEndpointsApiExplorer();
            // Add Swagger generator services.
            builder.Services.AddSwaggerGen();

            // Build the application.
            var app = builder.Build();

            // Configure the HTTP request pipeline.

            // If the application is in development mode...
            if (app.Environment.IsDevelopment())
            {
                // Enable middleware to serve generated Swagger as a JSON endpoint.
                app.UseSwagger();
                // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.),
                // specifying the Swagger JSON endpoint.
                app.UseSwaggerUI();
            }

            // Adds middleware for authorization.
            app.UseAuthorization();

            // Adds endpoints for controller actions to the IEndpointRouteBuilder.
            app.MapControllers();

            // Run the application.
            app.Run();
        }
    }
}
