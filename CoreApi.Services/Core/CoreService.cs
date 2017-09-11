using System;
using CoreApi.DataContext.Infrastructure;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Logging;

namespace CoreApi.Services.Core
{
    public interface ICoreService<out T> : IDisposable
    {
        IUnitOfWork UnitOfWork { get; }
        ILogger<T> Logger { get; }
        IFileProvider FileProvider { get; }
    }

    public class CoreService<T> : ICoreService<T>
    {
        public IUnitOfWork UnitOfWork { get; }
        public ILogger<T> Logger { get; }
        public IFileProvider FileProvider { get; }

        public CoreService(
            IUnitOfWork unitOfWork,
            ILogger<T> logger,
            IFileProvider fileProvider)
        {
            UnitOfWork = unitOfWork;
            Logger = logger;
            FileProvider = fileProvider;
        }

        public void Dispose()
        {
            UnitOfWork?.Dispose();
        }
    }
}
