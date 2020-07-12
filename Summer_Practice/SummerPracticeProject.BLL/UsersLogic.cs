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
using System.Security.Cryptography;

namespace SummerPracticeProject.BLL
{
    public class UsersLogic: IUsersLogic
    {
        private static IUsersDao _userDao;
        public UsersLogic(IUsersDao userDao)
        {
            _userDao = userDao;
        }
        public void Add(Users user)
        {
            
            _userDao.Add(user);
        }
        public bool Authentication(Users user)
        {
            
            return _userDao.Authentication(user);
        }
        public Users GetById(int id)
        {
            return _userDao.GetById(id);
        }

        public Users GetByLogin(string login)
        {
            return _userDao.GetByLogin(login);
        }

        public void Edit(Users user)
        {
            _userDao.Edit(user);
        }
    }
}
