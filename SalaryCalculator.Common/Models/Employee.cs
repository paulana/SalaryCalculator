using System;

namespace SalaryCalculator.Common.Models
{
    public class Employee
    {
        public Guid EmployeeID { get; } = Guid.NewGuid();
        public static string CacheKey { get; } = "Employee";
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal BenefitCost { get; set; }
        public decimal CheckAfterBenefits { get; set; }
        public int Salary { get; set; } = PayCheck * TotalPayChecks;
        public static int PayCheck { get; set; } = 2000;
        public static int TotalPayChecks { get; set; } = 26;
    }
}
