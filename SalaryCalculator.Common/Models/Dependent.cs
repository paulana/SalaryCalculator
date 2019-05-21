using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryCalculator.Common.Models
{
    public class Dependent
    {
        public static string CacheKey = "Dependent";

        public Guid DependentId = Guid.NewGuid();
        public Guid Employee { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set;}
        public int Type { get; set; }
        public bool Discounted { get; set; }
    }
}
