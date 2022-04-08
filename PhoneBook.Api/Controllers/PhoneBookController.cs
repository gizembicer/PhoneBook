using Microsoft.AspNetCore.Mvc;
using PhoneBook.Api.BusinessEngine.Interfaces;
using PhoneBook.Contracts.BindingModels;
using PhoneBook.Contracts.Dtos;

namespace PhoneBook.Api.Controllers
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
            var returnResult = _phoneBookBusinessEngine.ContactList();
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
        [HttpPost, Route("add-contact")]
        public IActionResult AddContact(ContactBindingModel model)
        {
            var returnResult = _phoneBookBusinessEngine.AddContact(model);
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
        [HttpPut, Route("update-contact")]
        public IActionResult UpdateContact(ContactBindingModel model)
        {
            var returnResult = _phoneBookBusinessEngine.UpdateContact(model);
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
        [HttpDelete, Route("contact")]
        public IActionResult DeleteContact(ContactBindingModel model)
        {
            var returnResult = _phoneBookBusinessEngine.DeleteContact(model);
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
        [HttpGet, Route("contact-informations")]
        public IActionResult GetContactInformations(Guid contactId)
        {
            var returnResult = _phoneBookBusinessEngine.ContactInformationList(contactId);
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
        [HttpPost, Route("add-contact-information")]
        public IActionResult AddContactInformation(ContactInformationBindingModel model)
        {
            var returnResult = _phoneBookBusinessEngine.AddContactInformation(model);
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
        [HttpPut, Route("update-contact-information")]
        public IActionResult UpdateContactInformation(ContactInformationBindingModel model)
        {
            var returnResult = _phoneBookBusinessEngine.UpdateContactInformation(model);
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
        [HttpDelete, Route("contact-information")]
        public IActionResult DeleteContactInformation(ContactInformationBindingModel model)
        {
            var returnResult = _phoneBookBusinessEngine.DeleteContactInformation(model);
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
