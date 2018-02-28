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
        
            _trailFactory = trailFactory;
        }
       
        [HttpGet("")]
        public IActionResult Index()
        {
         
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
