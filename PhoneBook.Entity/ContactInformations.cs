using PhoneBook.Contracts.Enums;
using PhoneBook.Entity.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace PhoneBook.Entity
{
    public class ContactInformations : PhoneBookCreatedEntityBase<Guid>
    {
        public Guid ContactId { get; set; }
        public InformationType Type { get; set; }
        public string Content { get; set; }
    }
}
