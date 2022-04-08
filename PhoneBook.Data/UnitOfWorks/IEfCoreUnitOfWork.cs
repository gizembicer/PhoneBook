namespace PhoneBook.Data.UnitOfWorks
{
    public interface IEfCoreUnitOfWork
    {
        Task CommitAsync();
        void Commit();
    }
}
