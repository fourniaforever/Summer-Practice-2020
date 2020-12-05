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
    public class RatesRepository:RatesIRepository<Rates>
    {
        private ShopRatesContext db;

        public RatesRepository(ShopRatesContext context)
        {
            db = context;
        }

        public IEnumerable<Rates> GetAll()
        {
            return db.Rates;
        }

        public Rates GetById(int id)
        {
            return db.Rates.Find(id);
        }

        public void Add(Rates rates)
        {
            db.Rates.Add(rates);
        }
        public void Remove(int id)
        {
            Rates rates = db.Rates.Find(id);
            if (rates != null)
                db.Rates.Remove(rates);
        }

    }
}
