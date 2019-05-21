using SalaryCalculator.API.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Runtime.Caching;
using System.Threading.Tasks;

namespace SalaryCalculator.API.Repositories
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class Repository<T> : IRepository<T>
        where T : class
    {
        private static readonly TimeSpan cacheDuration = TimeSpan.FromDays(7);
        public virtual async Task<IDictionary<Guid,T>> GetAllAsync(string cacheKey)
        {
            IDictionary<Guid, T> set = MemoryCache.Default.Get(cacheKey) as IDictionary<Guid, T>;
            if (set == null)
            {
                set = new Dictionary<Guid, T>();
                MemoryCache.Default.Set(cacheKey, set, DateTime.Now.Add(cacheDuration));
            }
            return set;
        }

        public virtual async Task<T> GetByIdAsync(string cacheKey, Guid guid)
        {
            IDictionary<Guid, T> set = MemoryCache.Default.Get(cacheKey) as IDictionary<Guid, T>;
            if (set == null)
            {
                set = new Dictionary<Guid, T>();
                MemoryCache.Default.Set(cacheKey, set, DateTime.Now.Add(cacheDuration));
                return null;
            }
            return set[guid];
        }

        public virtual async Task<T> InsertAsync(T model, string cacheKey, Guid guid)
        {
            IDictionary<Guid, T> set = MemoryCache.Default.Get(cacheKey) as IDictionary<Guid, T>;
            if (set == null)
            {
                set = new Dictionary<Guid, T>();
                MemoryCache.Default.Set(cacheKey, set, DateTime.Now.Add(cacheDuration));
            }
            set[guid] = model;
            MemoryCache.Default.Set(cacheKey, set, DateTime.Now.Add(cacheDuration));
            return model;
        }

        public virtual async Task<T> UpdateAsync(T model, string cacheKey, Guid guid)
        {
            IDictionary<Guid, T> set = MemoryCache.Default.Get(cacheKey) as IDictionary<Guid, T>;
            if (set == null)
            {
                set = new Dictionary<Guid, T>();
                MemoryCache.Default.Set(cacheKey, set, DateTime.Now.Add(cacheDuration));
            }
            set[guid] = model;
            MemoryCache.Default.Set(cacheKey, set, DateTime.Now.Add(cacheDuration));
            return model;
        }

        public virtual async Task<bool> DeleteAsync(string cacheKey, Guid guid)
        {
            IDictionary<Guid, T> set = MemoryCache.Default.Get(cacheKey) as IDictionary<Guid, T>;
            if (set == null)
            {
                set = new Dictionary<Guid, T>();
                MemoryCache.Default.Set(cacheKey, set, DateTime.Now.Add(cacheDuration));
                return false;
            }
            set.Remove(guid);
            MemoryCache.Default.Set(cacheKey, set, DateTime.Now.Add(cacheDuration));
            return true;
        }
    }
}
