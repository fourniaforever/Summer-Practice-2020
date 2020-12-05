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
    public class UsersRepository : UsersIRepository<Users>
    {
        private ShopRatesContext db;

        public UsersRepository(ShopRatesContext context)
        {
            db = context;
        }
        public bool Authentication(Users user)
        {
            return db.Users.Contains(user);
        }

        public void Edit(Users user)
        {
            db.Entry(user).State = EntityState.Modified;
        }

        public Users GetByLogin(string login)
        {
            return db.Users.Find(login);
        }

        public void Add(Users users)
        {
            db.Users.Add(users);
        }
    }
}
