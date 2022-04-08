using PhoneBook.Entity.Interfaces.Entities;

namespace PhoneBook.Data.Repositories
{
    public interface ITypedRepository<TEntity> : IDataRepository<TEntity> where TEntity : IEntity
    {
    }
}
