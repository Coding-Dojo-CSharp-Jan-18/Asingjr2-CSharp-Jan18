using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace time_display.Controllers

{
    public class TimeController : Controller
    {
        [HttpGet("")]
        public IActionResult Main()
        {
            return View();
        }
    }
}