using SalaryCalculator.API.Repositories.Interfaces;
using SalaryCalculator.API.Services.Interfaces;
using SalaryCalculator.Common.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

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

        public async Task<IDictionary<Guid,Employee>> GetAll()
        {
            return await _repository.GetAllAsync(Employee.CacheKey);
        }

        public async Task<Employee> Get(Guid guid)
        {
            return await _repository.GetByIdAsync(Employee.CacheKey, guid);
        }

        public async Task<Employee> Put(Employee model)
        {
            return await _repository.UpdateAsync(model, Employee.CacheKey, model.EmployeeID);
        }

        public async Task<Employee> Post(Employee model)
        {
            return await _repository.InsertAsync(model, Employee.CacheKey, model.EmployeeID);
        }

        public async Task<bool> Delete(Guid guid)
        {
            return await _repository.DeleteAsync(Employee.CacheKey, guid);
        }
    }
}