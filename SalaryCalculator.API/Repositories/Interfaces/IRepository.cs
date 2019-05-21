using System;
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
    public interface IRepository<T> : IDisposable where T : class
    {
        Task<ICollection<T>> GetAllAsync();

        Task<T> GetByIdAsync(int id);

        Task<T> InsertAsync(T entity);

        Task<T> UpdateAsync(T entity, int id);

        Task<int> DeleteAsync(int id);

        Task<int> DeleteAsync(Expression<Func<T, bool>> where);

        Task<T> FindAsync(Expression<Func<T, bool>> match);

        Task<ICollection<T>> FindManyAsync(Expression<Func<T, bool>> where);

        Task<int> CountAsync(Expression<Func<T, bool>> where);

        Task<bool> AnyAsync(Expression<Func<T, bool>> where);

        Task<TResult> MaxAsync<TResult>(Expression<Func<T, bool>> where, Expression<Func<T, TResult>> property);
    }
}