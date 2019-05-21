using SalaryCalculator.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace SalaryCalculator.API.Services.Interfaces
{
    /// <summary>
    /// Interface for Employee Service
    /// </summary>
    public interface IEmployeeService
    {
        Task<Employee> Get(Guid guid);
        Task<Employee> Put(Employee model);
        Task<Employee> Post(Employee model);
        Task<bool> Delete(Guid guid);
    }
}