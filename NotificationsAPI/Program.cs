global using NotificationsAPI.Data;
global using Microsoft.EntityFrameworkCore;
using System.Data.Odbc;


var builder = WebApplication.CreateBuilder(args);

// Add CORS Policy
var policyName = "_myAllowSpecificOrigins";
builder.Services.AddCors((c) => c.AddPolicy("cors", x => x.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin()));
//---

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// DbContext 
builder.Services.AddDbContext<NotificationsDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// Cors Policy
app.UseCors("cors");

app.UseAuthorization();

app.MapControllers();

app.Run();
