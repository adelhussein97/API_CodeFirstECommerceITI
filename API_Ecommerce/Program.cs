using Application.Contract;
using Application.Features.Category.Queries.GetAllCategories;
using ECommerceDbContext;
using Infrastructure;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add Connection String with Depndancy Injection (Singleton)
builder.Services.AddDbContext<ECommerce_DbContext>(options => 
                 options.UseSqlServer(builder.Configuration.GetConnectionString("APIConnectionString")));

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddMediatR(config => 
config.RegisterServicesFromAssemblies( typeof(GetAllCategoriesQuery).Assembly));
builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
var app = builder.Build();

app.MapControllers();

// Configure the HTTP request pipeline.


app.Run();

