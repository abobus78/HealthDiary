using HealthDiary.Entities;
using Microsoft.EntityFrameworkCore.Query;

namespace HealthDiary.IGenericRepositories
{
    public interface IGenericRepo<T>    
    {
        Task<bool> AddAsync(T entity);
        Task<bool> BulkUpdate(IEnumerable<T> entities);
        Task<bool> Update(T entity);
        Task<bool> DeleteAsync(T entity);
        Task<bool> DeleteAsync(int id);
        Task<bool> DeleteRangeAsync(IEnumerable<T> entities);
        Task<bool> AddRangeAsync(IEnumerable<T> entities);
        Task<T> GetByIdAsync(int id, Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null);
        IQueryable<T> GetAllAsyncQuery(Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null);
    }
}
