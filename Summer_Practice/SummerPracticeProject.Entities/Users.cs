using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SummerPracticeProject.Entities
{
    class Users
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Login { get; set; }
        public Binary Password { get; set; }
        public string City{ get; set; }

        public Users() { }

        public Users(int id, string n, string s, string l,Binary p,string c)
        {
            Id = id;
            Name = n;
            Surname = s;
            Login = l;
            Password = p;
            City = c;
        }
    }
}

