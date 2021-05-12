using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Backend
{
    public class FrotaContext : DbContext
    {
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }


        //public DbSet<Carro> Carros { get; set; }
        //public DbSet<Marca> Marcas { get; set; }
        //public DbSet<RegistroManutencao> RegistroManutencoes { get; set; }
        //public DbSet<AgendaManutencao> AgendaManutencoes { get; set; }
        //public DbSet<Manutencao> Manutencoes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseLazyLoadingProxies()
                .UseSqlServer(@"Server=.\SQLEXPRESS;Database=FrotaDB;Trusted_Connection = true");
        }
    }
}
