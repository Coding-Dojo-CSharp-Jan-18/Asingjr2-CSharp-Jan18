using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace dependency_injection.Controllers
{
    public class HomeController : Controller
    {
        /* ********************************PASSING CLASS OBJECT THROUGH CONSTRCUTOR */
        private Test _test;
        public HomeController(Test test)
        {
            _test = test;
        }
        // GET: /Home/
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            return View(_test);
        }
    }
}
