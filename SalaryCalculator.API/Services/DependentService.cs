using SalaryCalculator.API.Repositories.Interfaces;
using SalaryCalculator.API.Services.Interfaces;
using SalaryCalculator.Common.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SalaryCalculator.API.Services
{
    /// <summary>
    /// Dependent Service
    /// </summary>
    public class DependentService : IDependentService
    {
        private readonly IDependentRepository _repository;

        /// <summary>
        /// Dependent Service constructor
        /// </summary>
        public DependentService(IDependentRepository repository)
        {
            _repository = repository;
        } 

        public async Task<IDictionary<Guid, Dependent>> GetAll()
        {
            return await _repository.GetAllAsync(Dependent.CacheKey);
        }

        public async Task<Dependent> Get(Guid guid)
        {
            return await _repository.GetByIdAsync(Dependent.CacheKey, guid);
        }

        public async Task<Dependent> Put(Dependent model)
        {
            return await _repository.UpdateAsync(model, Dependent.CacheKey, model.DependentID);
        }

        public async Task<Dependent> Post(Dependent model)
        {
            return await _repository.InsertAsync(model, Dependent.CacheKey, model.DependentID);
        }

        public async Task<bool> Delete(Guid guid)
        {
            return await _repository.DeleteAsync(Dependent.CacheKey, guid);
        }
    }
}