using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace T3.S3Ledger.Api.Data.Repository.Interface
{
    public interface IRepository<T> where T : class
    {
        Task<T> GetAsync(long id);

        Task<T> GetAsync(int id);

        Task<IQueryable<T>> GetAllAsync(
            Expression<Func<T, bool>> filter = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            string includeProperties = null
            );

        Task<T> GetFirstOrDefaultAsync(
            Expression<Func<T, bool>> filter = null,
            string includeProperties = null
            );

        Task AddAsync(T entity);

        void Update(T entity);

        void Remove(T entity);

        void RemoveRange(IEnumerable<T> entity);
    }
}
