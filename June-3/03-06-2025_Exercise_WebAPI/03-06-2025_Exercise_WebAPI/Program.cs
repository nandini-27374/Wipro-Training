using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using _03_06_2025_Exercise_WebAPI.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<_03_06_2025_Exercise_WebAPIContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("_03_06_2025_Exercise_WebAPIContext") ?? throw new InvalidOperationException("Connection string '_03_06_2025_Exercise_WebAPIContext' not found.")));

// Add services to the container.

builder.Services.AddControllers();
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

app.UseAuthorization();

app.MapControllers();

app.Run();
