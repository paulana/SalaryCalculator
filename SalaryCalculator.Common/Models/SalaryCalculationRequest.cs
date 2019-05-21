using System;
using System.Collections.Generic;

namespace SalaryCalculator.Common.Models
{
    public class SalaryCalculationRequest
    {
        public Guid Employee { get; set; }
        public List<Guid> Dependents { get; set; }
    }
}