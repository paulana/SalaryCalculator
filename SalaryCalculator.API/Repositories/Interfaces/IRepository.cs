﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using System.Web;

namespace SalaryCalculator.API.Repositories.Interfaces
{
    /// <summary>
    /// Generic Base Repository Interface for interacting with Memory Cache
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IRepository<T>
    {
        Task<IDictionary<Guid, T>> GetAllAsync(string cacheKey);

        Task<T> GetByIdAsync(string cacheKey, Guid guid);

        Task<T> InsertAsync(T model, string cacheKey, Guid guid);

        Task<T> UpdateAsync(T model, string cacheKey, Guid guid);

        Task<bool> DeleteAsync(T model, string cacheKey, Guid guid);
    }
}