using PhoneBook.Data.Repositories;
using PhoneBook.Entity;

namespace PhoneBook.Data.UnitOfWorks
{
    public interface IUnitOfWork 
    {
        public ITypedRepository<Contacts> Contacts { get; }
        public ITypedRepository<ContactInformations> ContactInformations { get; }
        public ITypedRepository<Reports> Reports { get; }
        public ITypedRepository<ReportDetails> ReportDetails { get; }
        Task CommitAsync();
        void Commit();
    }
}
