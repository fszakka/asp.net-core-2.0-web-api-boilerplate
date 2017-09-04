using CoreApi.DataContext.Infrastructure;
using Microsoft.EntityFrameworkCore;
using CoreApi.Infrastructure.Configurations;
using CoreApi.Models.Core;

namespace CoreApi.DataContext.Core
{
    public class CoreContext: DbContext, IUnitOfWork
    {
        public CoreContext(DbContextOptions<CoreContext> options)
            :base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.HasDefaultSchema(AppSettings.DefaultSchema);
            
            modelBuilder.ApplyConfiguration(new UploadedFileConfiguration());
        }

        public DbSet<UploadedFile> UploadedFiles { get; set; }
    }
}
