using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Dapper;

using lost_woods.Models;

namespace lost_woods.Controllers
{
    public class HomeController : Controller
    {
        private TrailFactory _trailFactory;
        public HomeController(TrailFactory trailFactory)
        {
            //  Service has creasted objects for this already because it was scoped...
            _trailFactory = trailFactory;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            // var thingy =_trailFactory.GetTrails();
            // return View(thingy);
            System.Console.WriteLine("hello");
            return View();
        }

        [HttpPost("addTrail")]
        public IActionResult addTrail()
        {
            return RedirectToAction("");
        }

        // add url param later
        [HttpGet("trail")]
        public IActionResult Trail()
        {
            return View();
        }
    }
}
