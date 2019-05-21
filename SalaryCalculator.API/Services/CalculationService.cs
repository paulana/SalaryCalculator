using SalaryCalculator.API.Repositories.Interfaces;
using SalaryCalculator.API.Services.Interfaces;
using SalaryCalculator.Common.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SalaryCalculator.API.Services
{
    /// <summary>
    /// Calculation Service
    /// </summary>
    public class CalculationService : ICalculationService
    {
        private readonly IDependentRepository _dependentRepository;
        private readonly IEmployeeRepository _employeeRepository;

        /// <summary>
        /// Calculation Service constructor
        /// </summary>
        public CalculationService(IDependentRepository dependentRepository, IEmployeeRepository employeeRepository) {
            _dependentRepository = dependentRepository;
            _employeeRepository = employeeRepository;
        }

        public async Task<SalaryCalculationResponse> Calculate(SalaryCalculationRequest request)
        {
            Employee employee = await _employeeRepository.GetByIdAsync(Employee.CacheKey, request.Employee);
            List<Dependent> dependents = new List<Dependent>();

            employee.BenefitCost = 1000;

            if (request.Dependents.Count > 0)
            {
                foreach (var dependent in request.Dependents)
                {
                    dependents.Add(await _dependentRepository.GetByIdAsync(Dependent.CacheKey, dependent));
                }

                foreach (var dependent in dependents)
                {
                    if (dependent.FirstName.ToLower().StartsWith("a"))
                    {
                        dependent.Discounted = true;
                        employee.BenefitCost += 500 * Dependent.DiscountRate;
                        continue;
                    }
                    employee.BenefitCost += 500;
                }
            }

            employee.CheckAfterBenefits = (employee.Salary - employee.BenefitCost) / Employee.TotalPayChecks;

            employee = await _employeeRepository.InsertAsync(employee, Employee.CacheKey, employee.EmployeeID);

            return new SalaryCalculationResponse
            {
                Employee = employee.EmployeeID,
                BenefitCost = employee.BenefitCost,
                CheckAfterBenefits = employee.CheckAfterBenefits
            };
        }
    }
}