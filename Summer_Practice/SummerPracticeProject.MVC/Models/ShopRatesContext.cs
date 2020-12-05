using System;
using System.Collections.Generic;
using System.Web;
using System.Data.Entity;

namespace SummerPracticeProject.MVC.Models
{
    public class ShopRatesContext:DbContext
    {
        public DbSet<Shops> Shops { get; set; }
        public DbSet<Rates> Rates { get; set; }
        public DbSet<Users> Users { get; set; }
    }
}