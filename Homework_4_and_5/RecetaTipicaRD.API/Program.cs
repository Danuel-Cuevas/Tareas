using RecetaTipicaRD.Application.Contract;
using RecetaTipicaRD.Application.Service;
using RecetaTipicaRD.Infrastructure.Context;
using RecetaTipicaRD.Infrastructure.Interfaces;
using RecetaTipicaRD.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;

namespace RecetaTipicaRD.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddDbContext<RecetaTipicaRDContext>(options =>
            options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

            builder.Services.AddScoped<IUsuarioRTRepository, UsuarioRTRepository>();
            builder.Services.AddScoped<IUsuarioRTService, UsuarioRTService>();

            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();
            app.UseAuthorization();
            app.MapControllers();
            app.Run();
        }
    }
}
