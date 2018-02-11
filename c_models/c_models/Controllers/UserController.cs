using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using c_models.Models;

namespace c_models.Controllers
{
    public class UserController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            System.Console.WriteLine("Hello");
            // Creating Model
            User first = new User()
            {
                Name = "Arthur", 
                Email = "Art@a.com",
                Password = "Arthur"

            };
            ViewBag.First= first;

            TestModel test1 = new TestModel()
            {
                word  = "awesomeness",
                nums = 102
            };
            ViewBag.Test1 = test1;
            // Can pass model as ViewBag or through View function
            // return View(first);
            // return View(test1);
            return View();
        }


        [HttpPost("post")]
        // Creating with a arguement of a class
        public IActionResult Method(User user)
        {
            if (ModelState.IsValid)
            {
                return Json(user);
            }
            ViewBag.errors = ModelState.Values;
            return View("Index", user);
        }
    
       
    }    
}