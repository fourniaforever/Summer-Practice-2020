using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SummerPracticeProject.MVC.Models
{
    public class Rates
    {
        public int Id { get; set; }
        public int IdShop { get; set; }
        public DateTime Date { get; set; }
        public int Rate { get; set; }
        public int RateBy { get; set; }
    }
}