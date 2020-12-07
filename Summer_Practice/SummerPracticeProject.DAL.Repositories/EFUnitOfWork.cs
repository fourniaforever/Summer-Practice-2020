using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SummerPracticeProject.DAL.EF;
using SummerPracticeProject.Dao.Interfaces;
using SummerPracticeProject.Entities;

namespace SummerPracticeProject.DAL.Repositories
{
    public class EFUnitOfWork:IUnitOfWork
    {
        private ShopRatesContext db;
        private ShopsRepository shopsRepository;
        private RatesRepository ratesRepository;
        private UsersRepository usersRepository;

        public EFUnitOfWork(string connectionString)
        {
            db = new ShopRatesContext(connectionString);
        }
        public ShopsIRepository<Shops> Shops
        {
            get
            {
                if (shopsRepository == null)
                    shopsRepository = new ShopsRepository(db);
                return shopsRepository;
            }
        }

        public RatesIRepository<Rates> Rates
        {
            get
            {
                if (ratesRepository == null)
                    ratesRepository = new RatesRepository(db);
                return ratesRepository;
            }
        }

        public UsersIRepository<Users> Users
        {
            get
            {
                if (usersRepository == null)
                    usersRepository = new UsersRepository(db);
                return usersRepository;
            }
        }
        public void Save()
        {
            db.SaveChanges();
        }

        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
                this.disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
