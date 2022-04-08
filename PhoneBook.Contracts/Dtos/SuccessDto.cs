using PhoneBook.Contracts.Dtos.Interfaces;

namespace PhoneBook.Contracts.Dtos
{
    public class SuccessDto : ISuccessDto, IDto
    {
        public object Data { get; set; }
        public SuccessDto(object data)
        {
            Data = data;
        }
    }
}
