using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using PhoneBook.Entity;

namespace PhoneBook.Data.Configurations
{
    public class ReportsDbMap : BaseCreatedEntityDbMap<Reports, Guid>
    {
        public override void Configure(EntityTypeBuilder<Reports> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.Name).HasColumnType("VARCHAR(50)");
            builder.ToTable("Reports");
        }
    }
}
