using AngularcrudWebApi.DBModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace AngularcrudWebApi.PgContext
{
    public class PgContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        //public PgContext()
        //{
        //    Database.EnsureCreated();
        //}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=TestBasePostgree;Username=postgres;Password=postgres");
        }
    }
}
