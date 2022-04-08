using PhoneBook.Contracts.Dtos.Interfaces;

namespace PhoneBook.Contracts.Dtos
{
    public class ErrorDto : IErrorDto, IDto
    {
        public string ErrorCode { get; set; }
        public List<string> ErrorMessages { get; set; }

        public ErrorDto(params string[] errorMessages)
        {
            ErrorMessages = errorMessages.ToList();
        }
    }
}
