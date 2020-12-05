using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SummerPracticeProject.MVC.Models
{
    public class Users
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Login { get; set; }
        public byte[] Password { get; set; }
        public string City { get; set; }
    }
}