using Microsoft.EntityFrameworkCore;
using RestauranteElEmperador.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestauranteElEmperador.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) {

        }

        public DbSet<Cliente> clientes { get; set; }

        public DbSet<Plato> platos { get; set; }

        public DbSet<Menu> menus { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }


    }
}
