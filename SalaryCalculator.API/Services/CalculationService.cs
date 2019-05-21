using SalaryCalculator.API.Repositories.Interfaces;
using SalaryCalculator.API.Services.Interfaces;
using SalaryCalculator.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace SalaryCalculator.API.Services
{
    /// <summary>
    /// Calculation Service
    /// </summary>
    public class CalculationService : ICalculationService
    {
        /// <summary>
        /// Calculation Service constructor
        /// </summary>
        public CalculationService() { }

        public async Task<SalaryCalculationResponse> Get(SalaryCalculationRequest request)
        {
            throw new NotImplementedException();
        }
    }
}