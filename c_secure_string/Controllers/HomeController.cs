using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace c_secure_string.Controllers
{
    public class HomeController : Controller
    {
        private DbConnector _dbConnector;
        public HomeController(DbConnector dbConnector)
        {
            _dbConnector = dbConnector;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }

       
    }
}
