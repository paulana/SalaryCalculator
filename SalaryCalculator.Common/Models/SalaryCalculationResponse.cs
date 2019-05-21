using System;

namespace SalaryCalculator.Common.Models
{
    public class SalaryCalculationResponse
    {
        public Guid Employee { get; set; }
        public decimal BenefitCost { get; set; }
        public decimal CheckAfterBenefits { get; set; }
    }
}