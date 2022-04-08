using Microsoft.EntityFrameworkCore;
using PhoneBook.Data.Configurations;
using PhoneBook.Data.Extensions;
using PhoneBook.Entity;
using PhoneBook.Entity.Interfaces.Entities;

namespace PhoneBook.Data.Context
{
    public class DataContext : DbContext, IDataContext
    {
        public DbSet<Contacts> Contacts { get; set; }
        public DbSet<ContactInformations> ContactInformations { get; set; }
        public DbSet<Reports> Reports { get; set; }
        public DbSet<ReportDetails> ReportDetails { get; set; }
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            Database.SetCommandTimeout(100);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            foreach (var entityType in modelBuilder.Model.GetEntityTypes())
            {
                if (typeof(ISoftDelete).IsAssignableFrom(entityType.ClrType))
                {
                    entityType.AddSoftDeleteQueryFilter();
                }
            }
            modelBuilder.ApplyConfiguration(new ContactsDbMap());
            modelBuilder.ApplyConfiguration(new ContactInformationsDbMap());
            modelBuilder.ApplyConfiguration(new ReportsDbMap());
            modelBuilder.ApplyConfiguration(new ReportDetailsDbMap());
        }
    }
}
