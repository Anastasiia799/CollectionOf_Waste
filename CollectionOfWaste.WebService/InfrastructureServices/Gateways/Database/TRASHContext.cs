using Microsoft.EntityFrameworkCore;
using TRASH.DomainObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace TRASH.InfrastructureServices.Gateways.Database
{
    public class TRASHContext : DbContext
    {
        public DbSet<DomainObjects.TRASH> TRASHs { get; set; }


        public TRASHContext(DbContextOptions options)
            : base(options)
        { }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DomainObjects.TRASH>().HasData(
              new DomainObjects.TRASH()
              {
                  Id = 1L,
                  Name = "Контейнерная площадка № 1987645",
                  Space = "18",
                  TypeArea = "Контейнерная площадка",
                  
              }
           );
        }      
    }
}
