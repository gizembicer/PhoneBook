using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PhoneBook.Entity;

namespace PhoneBook.Data.Configurations
{
    public class ContactInformationsDbMap : BaseCreatedEntityDbMap<ContactInformations, Guid>
    {
        public override void Configure(EntityTypeBuilder<ContactInformations> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.Content).HasColumnType("VARCHAR(50)");
            builder.ToTable("ContactInformations");
        }
    }
}
