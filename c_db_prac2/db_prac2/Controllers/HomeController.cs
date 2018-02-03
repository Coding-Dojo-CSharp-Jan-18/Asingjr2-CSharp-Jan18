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
            string query2 = "SELECT * from CARS";
            var allCars = DbConnector.Query(query2);
            ViewBag.AC = allCars;
            System.Console.WriteLine("came to index");
            return View();
        }
       
        [HttpPost("post")]
        public IActionResult post(string make, string model)
        {
            string query = $"INSERT INTO cars (make, model) VALUES ('{make}', '{model}')";
            DbConnector.Execute(query);
            System.Console.WriteLine("came to post");
            System.Console.WriteLine(make);
            System.Console.WriteLine(model);
            return RedirectToAction("Index");
        }
      
    }
}
