using Microsoft.EntityFrameworkCore;
using WebApplication4.Models;
using WebApplication4.Repositories;
using WebApplication4.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddScoped<IProductService, ProductService>();

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddDbContext<SalesDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("SalesDbContext")));
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
