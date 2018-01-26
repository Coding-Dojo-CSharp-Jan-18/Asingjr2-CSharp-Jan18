using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace session.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            System.Console.WriteLine("Index page sir");
            HttpContext.Session.SetString("UserName", "Genevieve");
            string gen = HttpContext.Session.GetString("UserName");
            ViewBag.Gen = gen;
            HttpContext.Session.SetInt32("Age", 50);
            int? age_num = HttpContext.Session.GetInt32("Age");
            ViewBag.Age = age_num;
            return View();
        }
        [HttpGet("logout")]
        public IActionResult Logout()
        {
            System.Console.WriteLine("came to logout");
            HttpContext.Session.Clear();
            return RedirectToAction("results");
        }
        [HttpGet("results")]
        public IActionResult Results()
            {
                string gen = HttpContext.Session.GetString("UserName");
                ViewBag.Gen = gen;
                int? age_num = HttpContext.Session.GetInt32("Age");
                ViewBag.Age = age_num;
                return View();
            }
    }
    }
