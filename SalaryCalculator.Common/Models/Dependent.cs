using System;

namespace SalaryCalculator.Common.Models
{
    public class Dependent
    {
        public Guid DependentID { get; } = Guid.NewGuid();
        public static decimal DiscountRate { get; set; } = 0.1M;
        public static string CacheKey { get; } = "Dependent";
        public Guid Employee { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set;}
        public int Type { get; set; }
        public bool Discounted { get; set; }
    }
}
