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
    public class UsersDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Login { get; set; }
        public byte[] Password { get; set; }
        public string City { get; set; }
    }
}
