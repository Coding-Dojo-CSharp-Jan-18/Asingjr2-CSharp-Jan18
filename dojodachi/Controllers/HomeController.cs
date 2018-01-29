using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;


namespace dojodachi.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            if(HttpContext.Session.GetObjectFromJson<DD>("dachi") == null)
            {
                DD dachi = new DD();
                HttpContext.Session.SetObjectAsJson("dachi", dachi);

            }

            // int en = dachi.energy;
            // int hap = dachi.happiness;
            // int ful = dachi.fullness;
            // int meals = dachi.meals;
            HttpContext.Session.SetInt32("happiness", dachi.happiness );
            HttpContext.Session.SetInt32("fullness", dachi.fullness);
            HttpContext.Session.SetInt32("energy", dachi.energy);
            HttpContext.Session.SetInt32("meals", dachi.meals);
            return View();
        }
        [HttpPost("posty")]
        public IActionResult posty(string activity)
        {
            if (activity == "feed")
            {
                System.Console.WriteLine("feed");
                return RedirectToAction(" ");
            }
            else if (activity == "play")
            {
                System.Console.WriteLine("play");
                return RedirectToAction(" ");
            }
            else if (activity == "sleep")
            {
                System.Console.WriteLine("sleep");
                return RedirectToAction(" ");
            }
            // Work
            else 
            {
                System.Console.WriteLine("work");
                return RedirectToAction(" ");
            }
        }

    }
}
