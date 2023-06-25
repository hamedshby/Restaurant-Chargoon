using RestaurantChargoon.Domain.Contracts;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var types = Directory.GetFiles(AppDomain.CurrentDomain.BaseDirectory, "*.dll")
                .SelectMany(s => Assembly.LoadFrom(s).GetTypes())
                .Where(p => typeof(IDependencyRegistrar).IsAssignableFrom(p) && !p.IsInterface);
foreach (var type in types)
    ((IDependencyRegistrar)Activator.CreateInstance(type)).ConfigureServices(builder.Services);


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
