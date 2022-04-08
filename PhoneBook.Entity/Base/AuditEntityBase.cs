using PhoneBook.Entity.Interfaces.Entities;

namespace PhoneBook.Entity.Base
{
    public abstract class AuditEntityBase<TKey> : EntityBase<TKey>, IAuditEntity<TKey>
    {
        public DateTime CreatedAt { get; set; }
        public DateTime? ModifiedAt { get; set; }
    }
}
