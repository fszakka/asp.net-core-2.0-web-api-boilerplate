using System;
using System.Threading;
using System.Threading.Tasks;

namespace CoreApi.DataContext.Infrastructure
{
    public interface IUnitOfWork: IDisposable
    {
        int SaveChanges();
        int SaveChanges(bool acceptAllChangesOnSuccess);
        Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default(CancellationToken));
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default(CancellationToken));
    }
}