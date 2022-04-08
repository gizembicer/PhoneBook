using Microsoft.AspNetCore.Mvc;

namespace PhoneBook.Api.Host.Controller
{
    public class HomeController : ControllerBase
    {
        public async Task<IActionResult> Index()
        {
            return Content("Index");
        }
    }
}
