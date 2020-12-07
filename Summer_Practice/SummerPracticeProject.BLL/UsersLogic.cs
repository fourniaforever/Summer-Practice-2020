using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using SummerPracticeProject.Entities;
using SummerPracticeProject.BLL.Interfaces;
using SummerPracticeProject.DAL;
using SummerPracticeProject.Dao.Interfaces;


namespace SummerPracticeProject.BLL
{
    public class UsersLogic:IUsersLogic
    {
        private IUsersDao _usersDao;
        public UsersLogic(IUsersDao usersDao)
        {
            _usersDao = new UsersDAO();
        }

        public void Add(Users item)
        {
            _usersDao.Add(item);
        }

        public bool Authentication(Users user)
        {
            return _usersDao.Authentication(user);
        }

        public void Edit(Users user)
        {
            _usersDao.Edit(user);
        }

        public Users GetByLogin(string login)
        {
            return _usersDao.GetByLogin(login);
        }
    }
}
