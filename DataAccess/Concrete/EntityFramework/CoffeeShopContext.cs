using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System.Configuration;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class CoffeeShopContext : DbContext
    {
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            SeedCoffeeShops(builder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=CoffeeShop;Trusted_Connection=True;MultipleActiveResultSets=true");
        }

        private void SeedCoffeeShops(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CoffeeShop>().HasData(
                new CoffeeShop { CoffeeShopId = 1, CoffeeShopName = "Starbucks", CheckMernis = true},
                new CoffeeShop { CoffeeShopId = 2, CoffeeShopName = "Arabica", CheckMernis = false}
            );
        }

        public virtual DbSet<CoffeeShop> CoffeeShop { get; set; }
        public virtual DbSet<Customer> Customer { get; set; }
        
    }
}
