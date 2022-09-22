using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RestaurantAPI.Data;
using RestaurantAPI;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<RestaurantAPIContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("RestaurantAPIContext") ?? throw new InvalidOperationException("Connection string 'RestaurantAPIContext' not found.")));

// Add services to the container.
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

app.MapItemEndpoints();

app.Run();