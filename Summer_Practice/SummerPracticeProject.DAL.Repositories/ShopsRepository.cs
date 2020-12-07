using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SummerPracticeProject.DAL;
using SummerPracticeProject.Entities;
using SummerPracticeProject.Dao.Interfaces;
using SummerPracticeProject.DAL.EF;
using System.Data.Entity;

namespace SummerPracticeProject.DAL.Repositories
{
    public class ShopsRepository:ShopsIRepository<Shops>
    {
        private ShopRatesContext db;

        public ShopsRepository(ShopRatesContext context)
        {
            db = context;
        }

        public IEnumerable<Shops> GetAll()
        {
            return db.Shops;
        }

        public Shops GetById(int id)
        {
            return db.Shops.Find(id);
        }

        public void Add(Shops shop)
        {
            db.Shops.Add(shop);
        }

        public void Remove(int id)
        {
            Shops shops = db.Shops.Find(id);
            if (shops != null)
                db.Shops.Remove(shops);
        }

        public Shops GetByRate(int item)
        {
           return db.Shops.Find(item);
        }

        public IEnumerable<string> SelectShopsByRate(int item)
        {
            throw new NotImplementedException();
        }
    }
}
