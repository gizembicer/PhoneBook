using Microsoft.AspNetCore.Mvc;
using PhoneBook.Contracts.Dtos;
using PhoneBook.Report.BusinessEngine.Interfaces;

namespace PhoneBook.Report.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReportController : ControllerBase
    {
        private readonly IReportBusinessEngine _reportBusinessEngine;
        public ReportController(IReportBusinessEngine reportBusinessEngine)
        {
            _reportBusinessEngine = reportBusinessEngine;
        }

        [HttpGet, Route("reports")]
        public IActionResult Reports()
        {
            var returnResult = _reportBusinessEngine.ReportList();
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

        [HttpGet, Route("reportDetails")]
        public IActionResult ReportDetails(Guid reportId)
        {
            var returnResult = _reportBusinessEngine.ReportDetails(reportId);
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
