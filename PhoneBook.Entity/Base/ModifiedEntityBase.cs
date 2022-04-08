using PhoneBook.Entity.Interfaces.Entities;

namespace PhoneBook.Entity.Base
{
    public abstract class ModifiedEntityBase<TKey> : EntityBase<TKey>, IModifiedAtEntity
    {
        public DateTime? ModifiedAt { get; set; }
    }
}
