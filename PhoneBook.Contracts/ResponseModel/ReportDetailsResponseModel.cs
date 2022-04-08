using PhoneBook.Contracts.Enums;

namespace PhoneBook.Contracts.ResponseModel
{
    public class ReportDetailsResponseModel
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
