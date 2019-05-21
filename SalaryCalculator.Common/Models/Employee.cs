using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryCalculator.Common.Models
{
    public class Employee
    {
        public static string CacheKey = "Employee";
        public Guid EmployeeID = Guid.NewGuid();

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public static int PayCheck = 2000;
        public static int TotalPayChecks = 26;
        public static int Salary = PayCheck * TotalPayChecks; 
    }
}
