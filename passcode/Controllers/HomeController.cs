using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;


namespace passcode.Controllers
{
    public class HomeController : Controller
    {
        
        [HttpGet("")]
        public IActionResult Index()
        {
            int? try_count = HttpContext.Session.GetInt32("try_count");
            if(try_count == null)
            {
                try_count = 0;
            }
            try_count++;
            string choices = "ABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            string code = "";
            Random rand = new Random();
            for (int i = 0; i < 14; i++)
            {
                code = code + choices[rand.Next(0,choices.Length)];
            }
            ViewBag.Count = try_count;
            ViewBag.Code = code;
            HttpContext.Session.SetInt32("try_count", (int)try_count);
            return View();
        }
        [HttpPost("post")]
        public IActionResult Post()
        {
            
            return RedirectToAction("/");
        }

    
    }
}
