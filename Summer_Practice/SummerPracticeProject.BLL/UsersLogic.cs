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
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] password = Encoding.Default.GetBytes(user.Password);
                user.Hash = sha256.ComputeHash(password);
            }
            _userDao.Add(user);
        }
        public bool Authentication(Users user)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] password = Encoding.Default.GetBytes(user.Password);
                user.Hash = sha256.ComputeHash(password);
            }
            return _userDao.Authentication(user);
        }
    }
}
