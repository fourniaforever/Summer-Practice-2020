using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SummerPracticeProject.Entities
{
    public class Users
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Login { get; set; }
        public byte[]Password { get; set; }
       // public byte[] Hash { get; set; }
        public string City{ get; set; }

        public Users() { }
    }
}

