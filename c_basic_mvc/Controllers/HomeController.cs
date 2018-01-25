using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace c_basic_mvc.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            ViewBag.Fruits = new List<string>()
            {
                "Apple", "Pear", "Orange", "Grape"
            };

            var Person = new Dictionary<string, string>();
            Person.Add("James", "Seattle");
            Person.Add("Roy", "Spain");
            ViewBag.Person = Person;
            return View();
        }
        [HttpPost("submit")]
        public IActionResult Post(string hero)
        {
            ViewData["Hero"] = hero;
            return RedirectToAction("Show");
        }
        [HttpGet("show")]
        public IActionResult Show()
        {
            return View();
        }
    }
}
