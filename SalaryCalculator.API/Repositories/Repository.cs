using SalaryCalculator.API.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
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
        public virtual async Task<ICollection<T>> GetAllAsync()
        {
            return MemoryCache.Default.Get((T).CacheKey);
        }

        public virtual async Task<T> GetByIdAsync(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        public virtual async Task<T> InsertAsync(T entity)
        {
            var dbEntry = _dbContext.Entry(entity);
            if (dbEntry.State != EntityState.Detached)
                dbEntry.State = EntityState.Added;
            else
                _dbSet.Add(entity);
            _dbContext.SaveChanges();
            return dbEntry.Entity;
        }

        public virtual async Task<T> UpdateAsync(T entity, int id)
        {
            if (entity == null)
                return null;

            T existing = await _dbContext.Set<T>().FindAsync(id);
            if (existing != null)
            {
                _dbContext.Entry(existing).CurrentValues.SetValues(entity);
                await _dbContext.SaveChangesAsync();
            }
            return existing;
        }

        public virtual async Task<int> DeleteAsync(int id)
        {
            var entityToDelete = await _dbSet.FindAsync(id);

            if (entityToDelete == null) return 0;

            _dbSet.Remove(entityToDelete);
            return await _dbContext.SaveChangesAsync();
        }

        public virtual async Task<int> DeleteAsync(Expression<Func<T, bool>> where)
        {
            var entityToDelete = await _dbSet.Where(where).FirstOrDefaultAsync();

            if (entityToDelete == null) return 0;

            _dbSet.Remove(entityToDelete);
            return await _dbContext.SaveChangesAsync();
        }


        public virtual async Task<T> FindAsync(Expression<Func<T, bool>> match)
        {
            return await _dbSet.SingleOrDefaultAsync(match);
        }

        public virtual async Task<ICollection<T>> FindManyAsync(Expression<Func<T, bool>> where)
        {
            return await _dbSet.Where(where).ToListAsync();
        }

        public virtual async Task<int> CountAsync(Expression<Func<T, bool>> where)
        {
            return await _dbSet.CountAsync(where);
        }

        public virtual async Task<bool> AnyAsync(Expression<Func<T, bool>> where)
        {
            return await _dbSet.AnyAsync(where);
        }

        public virtual async Task<TResult> MaxAsync<TResult>(Expression<Func<T, bool>> where, Expression<Func<T, TResult>> property)
        {
            return await _dbSet.Where(where).MaxAsync(property);
        }

        #endregion

        public virtual void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (_dbContext != null)
                {
                    _dbContext.Dispose();
                    _dbContext = null;
                }
            }
        }
    }
}
