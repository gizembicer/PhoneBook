using Microsoft.AspNetCore.Mvc;
using PhoneBook.Api.BusinessEngine.Interfaces;
using PhoneBook.Contracts.Dtos;

namespace PhoneBook.Api.Host.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class PhoneBookController : ControllerBase
    {
        private readonly IPhoneBookBusinessEngine _phoneBookBusinessEngine;
        public PhoneBookController(IPhoneBookBusinessEngine phoneBusinessEngine)
        {
            _phoneBookBusinessEngine = phoneBusinessEngine;
        }

        [HttpGet, Route("contacts")]
        public IActionResult GetContacts()
        {
            var returnResult = _phoneBookBusinessEngine.GetContactList();
            ErrorDto errorDto = returnResult as ErrorDto;
            if (errorDto == null)
            {
                SuccessDto successDto = returnResult as SuccessDto;
                if (successDto != null)
                    return Ok(returnResult);
                else
                    return NotFound(returnResult);
            }
            else
                return BadRequest(returnResult);
        }
    }
}