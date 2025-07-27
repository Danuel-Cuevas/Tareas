using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RecetaTipicaRD.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace RecetaTipicaRD.Infrastructure.Context
{
    public class RecetaTipicaRDContext : DbContext
    {
        public RecetaTipicaRDContext(DbContextOptions<RecetaTipicaRDContext> options) : base(options)
        {
        }

        public DbSet<UsuarioRT> Usuarios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
            modelBuilder.Entity<UsuarioRT>().HasData(
                new UsuarioRT
                {
                    Id = 1,
                    Nombre = "Danuel",
                    Apellido = "Cuevas",
                    Correo = "Franche.fit@gmail.com",
                    Telefono = "809-111-000",
                    FechaNacimiento = new DateTime(1990, 5, 10),
                    PesoKg = 40,
                    AlturaCm = 160,
                    Genero = "Masculino"
                },
                new UsuarioRT
                {
                    Id = 2,
                    Nombre = "Ezequiel",
                    Apellido = "Tejeda",
                    Correo = "ez.tej@gmail.com",
                    Telefono = "809-999-8888",
                    FechaNacimiento = new DateTime(1988, 11, 2),
                    PesoKg = 78,
                    AlturaCm = 185,
                    Genero = "Masculino"
                }
            );
        }
    }
}
