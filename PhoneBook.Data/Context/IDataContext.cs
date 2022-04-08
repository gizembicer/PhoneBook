using Microsoft.EntityFrameworkCore;
using PhoneBook.Entity;

namespace PhoneBook.Data.Context
{
    public interface IDataContext
    {
        public DbSet<Contacts> Contacts { get; set; }
        public DbSet<ContactInformations> ContactInformations { get; set; }
        public DbSet<Reports> Reports { get; set; }
        public DbSet<ReportDetails> ReportDetails { get; set; }
    }
}
