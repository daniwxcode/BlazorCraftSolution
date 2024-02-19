using Framework.Domain.Models;

namespace Framework.App.Contracts.Persistence
{
    public interface IUnitOfWork<TId> : IDisposable
    {
        IRepositoryAsync<T, Guid> RepositoryAsync<T>() where T : AuditableEntity;

        Task<int> Commit(CancellationToken cancellationToken);

        Task<int> CommitAndRemoveCache(CancellationToken cancellationToken, params string[] cacheKeys);

        Task Rollback();
    }
}