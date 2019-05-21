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

        public async Task<Dependent> Get(Guid guid)
        {
            throw new NotImplementedException();
        }

        public async Task<Dependent> Put(Dependent model)
        {
            throw new NotImplementedException();
        }

        public async Task<Dependent> Post(Dependent model)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> Delete(Guid guid)
        {
            throw new NotImplementedException();
        }
    }
}