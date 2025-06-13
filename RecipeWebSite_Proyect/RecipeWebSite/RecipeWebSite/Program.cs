using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using RecipeWebSite.Data;
using System;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<RecipeWebSiteContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "RecipeWebSite API", Version = "v1" });
});

var app = builder.Build();

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "RecipeWebSite API v1");
    });
}

app.Run();
