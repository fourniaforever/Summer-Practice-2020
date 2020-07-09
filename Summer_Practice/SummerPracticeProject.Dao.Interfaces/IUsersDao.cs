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
        void Add(Users user);
        bool Authentication(Users user);
    }
}
