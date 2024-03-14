using gym_rutiKroivets.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System.Security.Cryptography;

namespace gym_rutiKroivets
{
    public class DataContext:DbContext
    {
        public DbSet<Guide> guides { get; set; }
        public DbSet<Student> students { get; set; }
        public DbSet<Training> trainings { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //if (!optionsBuilder.IsConfigured)
            //{
            //    optionsBuilder.UseSqlServer(connectionString,
            //        b => b.MigrationsAssembly("gym-rutiKroivets"));
            //}

            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=sample_db");
        }
       
    }
}
