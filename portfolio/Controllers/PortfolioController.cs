using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace  portfolio.Controllers
{
    public class Portfolio : Controller
    {
        [HttpGet("")]
        public IActionResult Home()
        {
            return View();
        }
        [HttpGet("projects")]
        public IActionResult Projects()
        {
            return View();
        }
        [HttpGet("contacts")]
        public IActionResult Contacts()
        {
            return View();
        }
    }
}