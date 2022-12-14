using System.Linq.Expressions;

namespace Experis_BE_Domain.Interfaces
{
    public interface ISqlRepository<T> where T : class
    {
        Task Insert(T obj);
        Task Update(T obj);
        Task Delete(Guid id);
        Task<IEnumerable<T>> Get(int page, int size, string includeProperties = "",
            Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null);
    }
}