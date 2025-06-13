using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RecipeWebSite.Models;
using System;

namespace RecipeWebSite.Data
{
    public class RecipeWebSiteContext : DbContext
    {
        public RecipeWebSiteContext(DbContextOptions<RecipeWebSiteContext> options) : base(options) { }

        public DbSet<User> Usuarios { get; set; }
        public DbSet<Recipe> Recetas { get; set; }
        public DbSet<Commentary> Comentarios { get; set; }
        public DbSet<Favorite> Favoritos { get; set; }
    }
}
