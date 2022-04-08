using PhoneBook.Contracts.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook.Contracts.BindingModels
{
    public class ReportDetailsBindingModel
    {
        public Guid ReportId { get; set; }
        public Guid ContactId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Company { get; set; }
        public Guid ContactInformationId { get; set; }
        public InformationType Type { get; set; }
        public string Content { get; set; }
    }
}
