using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace dojo_survey.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }
        // [HttpGet("Post")]
        // public IActionResult Post(string name, string location, string langauge, string comment)
        // {
        //     ViewBag.Name = name;
        //     ViewBag.Location = location;
        //     ViewBag.Language = langauge; 
        //     ViewBag.Comment = comment;
        //     return View("Results");
        // }

        // Code refractored to allow for the passing of URL params
        [HttpGet("Post")]
        public IActionResult Post(string name, string location, string langauge, string comment)
        {
            return RedirectToAction("Results", new{
                // Can define types later
                name = name, 
                location = location, 
                langauge = langauge,
                comment = comment
            });
        }
        [HttpGet("Results")]
        public IActionResult Results(string name, string location, string langauge, string comment)
        {
            ViewBag.Name = name;
            ViewBag.Location = location;
            ViewBag.Language = langauge;
            ViewBag.Comment = comment;
            return View();
        }
    }
}
