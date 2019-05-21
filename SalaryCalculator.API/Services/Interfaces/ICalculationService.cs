using SalaryCalculator.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace SalaryCalculator.API.Services.Interfaces
{
    /// <summary>
    /// Interface for Calculation Service
    /// </summary>
    public interface ICalculationService
    {
        Task<SalaryCalculationResponse> Get(SalaryCalculationRequest request);
    }
}