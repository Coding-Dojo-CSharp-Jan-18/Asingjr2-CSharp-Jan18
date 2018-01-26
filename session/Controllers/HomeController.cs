using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
// Required in order to utilize session
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace session.Controllers
{
    public static class SessionExtension
    {
        public static void SetObjectAsJson(this ISession session, string key, object value)
        {
            session.SetString(key, JsonConvert.SerializeObject(value));
        }
        public static T GetObjectFromJson<T>(this ISession session, string key)
        {
            string value = session.GetString(key);
            return value == null ? default(T) : JsonConvert.DeserializeObject<T>(value);
        }
    }

    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            System.Console.WriteLine("Index page sir");
            // Session only has two native types, string and int...below allow you to "set" and "get" them>
            HttpContext.Session.SetString("UserName", "Genevieve");
            string gen = HttpContext.Session.GetString("UserName");
            ViewBag.Gen = gen;
            // Sessions get example for integer
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

        [HttpGet("temp")]
        public IActionResult Temp()
        {
           return View("tempdata");
        }

        [HttpPost("tempdata")]
        public IActionResult TData(string color)
        {
            TempData["color"] = color;
            return RedirectToAction("print_temp");
        }
        [HttpGet("print_temp")]
        public IActionResult Print_Temp()
        {
            System.Console.WriteLine(TempData["color"]);
            return View("temp");
        }
    }
    }
