using SalaryCalculator.Common.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SalaryCalculator.API.Services.Interfaces
{
    /// <summary>
    /// Interface for Employee Service
    /// </summary>
    public interface IEmployeeService
    {
        Task<Employee> Get(Guid guid);
        Task<IDictionary<Guid,Employee>> GetAll();
        Task<Employee> Put(Employee model);
        Task<Employee> Post(Employee model);
        Task<bool> Delete(Guid guid);
    }
}