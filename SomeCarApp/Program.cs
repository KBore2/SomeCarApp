using MediatR;
using Microsoft.EntityFrameworkCore;
using Serilog;
using SomeCarApp.Commands.CreateCar;
using SomeCarApp.Domain.Interfaces;
using SomeCarApp.Domain.SeedWork;
using SomeCarApp.Domain.Services;
using SomeCarApp.Infrastructure;
using SomeCarApp.Infrastructure.Data;
using SomeCarApp.Infrastructure.Data.Repositories;
using SomeCarApp.Queries.GetCars;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);


builder.Host.UseSerilog((context, services, configuration) => configuration
                    .ReadFrom.Configuration(context.Configuration)
                    .ReadFrom.Services(services)
                    .Enrich.FromLogContext()
                    .WriteTo.Console());

// Services
builder.Services.AddTransient<ICarBrandService, CarBrandService>();
builder.Services.AddTransient<ICarService, CarService>();

builder.Services.AddTransient<ICarBrandRepository, CarBrandRepository>();
builder.Services.AddTransient<ICarRepository, CarRepository>();

builder.Services.AddTransient<IUnitOfWork, UnitOfWork>();

// MediatR
var commandAssembly = typeof(CreateCarCommand).GetTypeInfo().Assembly;
builder.Services.AddMediatR(commandAssembly);

var queryAssembly = typeof(GetCarsQuery).GetTypeInfo().Assembly;
builder.Services.AddMediatR(queryAssembly);

// Controllers
builder.Services.AddControllers();

// Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// DB Context
string migrationAssembly = typeof(Program).GetTypeInfo().Assembly.GetName().Name;
string connectionString = builder.Configuration.GetConnectionString("CarsDB");

builder.Services.
    AddDbContextFactory<CarAppContext>(options =>
    {
        options.UseSqlServer(connectionString, sqlOptions => sqlOptions.MigrationsAssembly(migrationAssembly));
    });
               

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
