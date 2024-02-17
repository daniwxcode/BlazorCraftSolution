using Framework.Domain.Contracts;
using Framework.Domain.Models;

namespace Framework.App.Contracts
{
    public interface IRepositoryAsync<T, in TId> where T : class, IEntity<TId>
    {
        IQueryable<T> Entities { get; }

        Task<T> GetByIdAsync(TId id);

        Task<List<T>> GetAllAsync();

        Task<List<T>> GetPagedDataAsync(int pageNumber, int pageSize);

        Task<T> AddAsync(T entity);       

        Task UpdateAsync(T entity);
        Task BulkUpdateAsync(IList<T> entity);
        Task DeleteAsync(T entity);
        Task BulkDeleteAsync(IList<T> entity);
    }
   

}
