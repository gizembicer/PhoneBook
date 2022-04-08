using PhoneBook.Entity.Base;

namespace PhoneBook.Entity
{
    public class Contacts : PhoneBookCreatedEntityBase<Guid>
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Company { get; set; }
        List<ContactInformations> ContactInformations { get; set; }
    }
}