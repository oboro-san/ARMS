using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ARMS.DataAccess.Data.Repository.IRepository
{
    public interface IRepository<T> where T : class
    {
        T Get(int id);

        /// <summary>
        /// Gets all Entity<T> from the database
        /// </summary>
        /// <param name="filter">Filters the search data by specified filter</param>
        /// <param name="orderBy">Orders the data</param>
        /// <param name="includeProperties">Gets related data</param>
        /// <returns>IEnumerabl</returns>
        IEnumerable<T> GetAllE(Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, string includeProperties = null);

        /// <summary>
        /// Gets all Entity from the database
        /// </summary>
        /// <param name="filter">Filters the search data by specified filter</param>
        /// <param name="orderBy">Orders the data</param>
        /// <param name="includeProperties">Gets related data</param>
        /// <returns>IQueryable</returns>
        IQueryable<T> GetAllQ(Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, string includeProperties = null);

        T FirstOrDefault(Expression<Func<T, bool>> filter = null, string includeProperties = null);

        Task<T> FirstOrDefaultAsync(Expression<Func<T, bool>> filter = null, string includeProperties = null);

        void Add(T entity);

        void Remove(int id);

        void Remove(T entity);

        void RemoveRange(IEnumerable<T> entity);
    }
}