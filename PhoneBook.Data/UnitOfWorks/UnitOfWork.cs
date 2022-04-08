using Microsoft.EntityFrameworkCore;
using PhoneBook.Data.Context;
using PhoneBook.Data.Repositories;
using PhoneBook.Entity;
using PhoneBook.Entity.Interfaces.Entities;

namespace PhoneBook.Data.UnitOfWorks
{
    public class UnitOfWork : EfCoreUnitOfWork<DataContext>, IUnitOfWork
    {
        public UnitOfWork(DataContext appDbContext) : base(appDbContext)
        {

        }
        private TypedRepository<Contacts> _contacts;
        private TypedRepository<ContactInformations> _contactInformations;
        private TypedRepository<ReportDetails> _reportDetails;
        private TypedRepository<Reports> _reports;

        public ITypedRepository<Contacts> Contacts => _contacts ??= new TypedRepository<Contacts>(Context);
        public ITypedRepository<ContactInformations> ContactInformations => _contactInformations ??= new TypedRepository<ContactInformations>(Context);
        public ITypedRepository<Reports> Reports => _reports ??= new TypedRepository<Reports>(Context);
        public ITypedRepository<ReportDetails> ReportDetails => _reportDetails ??= new TypedRepository<ReportDetails>(Context);

        public void Commit()
        {
            try
            {
                UpdateEntryStatuses();
                base.Commit();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public Task CommitAsync()
        {
            try
            {

                UpdateEntryStatuses();
                return base.CommitAsync();

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        private void UpdateEntryStatuses()
        {
            foreach (var entry in Context.ChangeTracker.Entries())
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.CurrentValues["IsDeleted"] = false;
                        if (entry.Entity is ICreatedAtEntity createdAtEntity)
                        {
                            createdAtEntity.CreatedAt = DateTime.Now;
                        }

                        break;
                    case EntityState.Modified:
                        if (entry.Entity is IModifiedAtEntity modifiedAtEntity)
                        {
                            modifiedAtEntity.ModifiedAt = DateTime.Now;
                        }
                        break;
                    case EntityState.Deleted:
                        entry.State = EntityState.Modified;
                        entry.CurrentValues["IsDeleted"] = true;
                        break;
                }
            }
        }
    }
}
