using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PhoneBook.Entity.Base;

namespace PhoneBook.Data.Configurations
{
    public abstract class BaseCreatedEntityDbMap<TEntity, TKey> : IEntityTypeConfiguration<TEntity> where TEntity : PhoneBookCreatedEntityBase<TKey>
    {
        public virtual void Configure(EntityTypeBuilder<TEntity> builder)
        {

            builder.HasKey(x => x.Id);
            builder.Property(x => x.IsDeleted).HasDefaultValue(false);
            builder.Property(x => x.CreatedAt).HasDefaultValueSql("(NOW())");
        }
    }
}
