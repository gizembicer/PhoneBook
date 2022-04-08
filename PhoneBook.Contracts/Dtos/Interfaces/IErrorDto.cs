using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook.Contracts.Dtos.Interfaces
{
    public interface IErrorDto
    {
        string ErrorCode { get; set; }
        List<string> ErrorMessages { get; set; }
    }
}
