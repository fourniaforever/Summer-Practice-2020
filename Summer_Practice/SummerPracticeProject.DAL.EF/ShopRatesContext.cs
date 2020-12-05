using System;
using System.Collections.Generic;
using System.Web;
using SummerPracticeProject.Entities;
using System.Data.Entity;

namespace SummerPracticeProject.DAL.EF
{
    public class ShopRatesContext:DbContext
    {
        public DbSet<Shops> Shops { get; set; }
        public DbSet<Rates> Rates { get; set; }
        public DbSet<Users> Users { get; set; }

        static ShopRatesContext()
        {
            Database.SetInitializer(new StoreDbInitializer());
        }
        public ShopRatesContext(string connectionString)
            : base(connectionString)
        {
        }

        public class StoreDbInitializer : DropCreateDatabaseIfModelChanges<ShopRatesContext>
        {
            protected override void Seed(ShopRatesContext db)
            {
                //db.Shops.Add(new Shops{ Name = "Nokia Lumia 630", Company = "Nokia", Price = 220 });
               // db.Phones.Add(new Phone { Name = "iPhone 6", Company = "Apple", Price = 320 });
              
                db.SaveChanges();
            }
        }
    }
}