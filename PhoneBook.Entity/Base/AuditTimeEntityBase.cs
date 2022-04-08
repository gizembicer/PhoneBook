using PhoneBook.Entity.Interfaces.Entities;

namespace PhoneBook.Entity.Base
{
    public abstract class AuditTimeEntityBase<TKey> : EntityBase<TKey>, ICreatedAtEntity, IModifiedAtEntity
    {
        public DateTime CreatedAt { get; set; }
        public DateTime? ModifiedAt { get; set; }
    }
}
