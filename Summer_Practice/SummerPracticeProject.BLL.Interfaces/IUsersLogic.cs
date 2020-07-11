using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SummerPracticeProject.Entities;

namespace SummerPracticeProject.BLL.Interfaces
{
    public interface IUsersLogic
    {
        void Add(Users user);
        bool Authentication(Users user);
        Users GetById(int id);
        Users GetByLogin(string login);
    }
}
