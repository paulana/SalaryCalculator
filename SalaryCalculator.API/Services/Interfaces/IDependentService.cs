using SalaryCalculator.Common.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SalaryCalculator.API.Services.Interfaces
{
    /// <summary>
    /// Interface for Dependent Service
    /// </summary>
    public interface IDependentService
    {
        Task<IDictionary<Guid, Dependent>> GetAll();
        Task<Dependent> Get(Guid guid);
        Task<Dependent> Put(Dependent model);
        Task<Dependent> Post(Dependent model);
        Task<bool> Delete(Guid guid);
    }
}