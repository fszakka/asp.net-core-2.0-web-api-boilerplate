using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CoreApi.Infrastructure.Features.Common
{
    public abstract class EntityBaseConfiguration<T> : IEntityTypeConfiguration<T> where T : EntityBase
    {
        public virtual void Configure(EntityTypeBuilder<T> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(x => x.CreateTime).IsRequired();
            builder.Property(x => x.UpdateTime).IsRequired();
            builder.Property(x => x.CreateUser).IsRequired().HasMaxLength(50);
            builder.Property(x => x.UpdateUser).IsRequired().HasMaxLength(50);
            builder.Property(x => x.LastAction).IsRequired().HasMaxLength(50);

            ConfigureDerived(builder);
        }

        public abstract void ConfigureDerived(EntityTypeBuilder<T> builder);
    }
}