using PhoneBook.Contracts.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook.Contracts.BindingModels
{
    public class ContactInformationBindingModel
    {
        public Guid Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ModifiedAt { get; set; }
        public Guid ContactId { get; set; }
        public InformationType Type { get; set; }
        public string Content { get; set; }
    }
}
