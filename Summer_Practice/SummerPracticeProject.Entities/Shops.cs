using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SummerPracticeProject.Entities
{
   public class Shops
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public Shops() { }

        public Shops(int id, string n, string a)
        {
            Id = id;
            Name = n;
            Address = a;
        }
    }
}
