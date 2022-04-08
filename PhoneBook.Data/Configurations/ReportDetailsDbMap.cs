using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PhoneBook.Entity;

namespace PhoneBook.Data.Configurations
{
    public class ReportDetailsDbMap : BaseCreatedEntityDbMap<ReportDetails, Guid>
    {
        public override void Configure(EntityTypeBuilder<ReportDetails> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.Name).HasColumnType("VARCHAR(20)");
            builder.Property(x => x.Surname).HasColumnType("VARCHAR(20)");
            builder.Property(x => x.Company).HasColumnType("VARCHAR(200)");
            builder.Property(x => x.Content).HasColumnType("VARCHAR(50)");
            builder.ToTable("ReportDetails");
        }
    }
}
