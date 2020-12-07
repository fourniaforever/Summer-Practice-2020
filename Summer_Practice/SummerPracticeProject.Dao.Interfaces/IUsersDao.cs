using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SummerPracticeProject.Entities;

namespace SummerPracticeProject.Dao.Interfaces
{
    public interface IUsersDao
    {
        bool Authentication(Users user);
        void Edit(Users user);
        Users GetByLogin(string login);
        void Add(Users item);
    }
}
