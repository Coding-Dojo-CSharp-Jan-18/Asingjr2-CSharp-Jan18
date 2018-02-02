using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace db_prac2.Controllers
{
    public class HomeController : Controller
    {
        // GET: /Home/
        [HttpGet("")]
        public IActionResult Index()
        {
            System.Console.WriteLine("came to index");
            return View();
        }
        [HttpPost("/post")]
        public IActionResult Post(string make, string model)
        {
            System.Console.WriteLine("came to post");
            System.Console.WriteLine(make);
            System.Console.WriteLine(model);
            return RedirectToAction("");
        }
    }
}
