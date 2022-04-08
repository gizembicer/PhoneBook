using PhoneBook.Entity.Interfaces.Entities;

namespace PhoneBook.Entity.Base
{
    public class PhoneBookCreatedEntityBase<T> : CreatedEntityBase<T>, ISoftDelete
    {
        public bool IsDeleted { get; set; }
    }
}
