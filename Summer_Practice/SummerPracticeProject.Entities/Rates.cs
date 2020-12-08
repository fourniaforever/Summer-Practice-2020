using System;

namespace SummerPracticeProject.Entities
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