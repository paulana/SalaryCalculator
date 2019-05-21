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
    /// Employee Service
    /// </summary>
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _repository;

        /// <summary>
        /// Employee Service constructor
        /// </summary>
        public EmployeeService(IEmployeeRepository repository)
        {
            _repository = repository;
        }

        public async Task<Employee> Get(Guid guid)
        {
            throw new NotImplementedException();
        }

        public async Task<Employee> Put(Employee model)
        {

        }

        public async Task<Employee> Post(Employee model)
        {

        }

        public async Task<bool> Delete(Guid guid)
        {

        }
    }
}