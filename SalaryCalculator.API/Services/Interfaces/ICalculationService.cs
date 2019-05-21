using SalaryCalculator.Common.Models;
using System.Threading.Tasks;

namespace SalaryCalculator.API.Services.Interfaces
{
    /// <summary>
    /// Interface for Calculation Service
    /// </summary>
    public interface ICalculationService
    {
        Task<SalaryCalculationResponse> Calculate(SalaryCalculationRequest request);
    }
}