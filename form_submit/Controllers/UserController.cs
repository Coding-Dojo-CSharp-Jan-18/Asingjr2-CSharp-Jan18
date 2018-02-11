using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace form_submit.Controllers
{
    public class UserController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            System.Console.WriteLine("came to home view");
            return View();
        }
        [HttpPost("post")]
        public IActionResult Post(string f, string l, int a, string e, string p)
        {
            System.Console.WriteLine("came to post");
            User newUser = new User(f,l,a,e,p)
            {
                fn = f,
                ln = l,
                age = a,
                email = e, 
                password = p
            };
            if(TryValidateModel(newUser) == true)
            {
                System.Console.WriteLine("user not valid");
            }
            else
            {
                System.Console.WriteLine("user is valid");
            }
            return RedirectToAction("Index");
        }
    
    }
}
