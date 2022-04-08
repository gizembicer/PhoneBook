using PhoneBook.Entity.Base;

namespace PhoneBook.Entity
{
    public class Reports : PhoneBookCreatedEntityBase<Guid>
    {
        public string Name { get; set; }

    }
}
