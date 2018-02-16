using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
// Below required for using session
using Microsoft.AspNetCore.Http;
// Below required to use serialize methods for non-native types
using Newtonsoft.Json;
// Below brings in session extension file I created for non-native type conversion/storage into and out of strings
using ajax_linq_session_recap.SessionExtension;
using Microsoft.AspNetCore.Razor.TagHelpers;
using ajax_linq_session_recap.Models;

namespace ajax_linq_session_recap.Controllers
{
    public class HomeController : Controller
    {
        // Basic index page with two forms.  One useing model validation.  
        // Simple session entry with both native and non-native data-types (object)
        [HttpGet("")]
        public IActionResult Index()
        {
            // Session Practice..extension method in different file
            if (HttpContext.Session.GetObjectFromJson<Team>("entry") == null)
            {HttpContext.Session.SetObjectAsJson("entry", new Team()); }
            if (HttpContext.Session.GetString("name") == null)
            { HttpContext.Session.SetString("name", "Jacob"); }
            if (HttpContext.Session.GetString("age") == null)
            { HttpContext.Session.SetInt32("age",30); }
            ViewBag.Name = HttpContext.Session.GetString("name");
            ViewBag.Age = HttpContext.Session.GetInt32("age");
            System.Console.WriteLine("came to index");
            return View();
        }

        // Results page to list teams and practice LINQ methods or queries
        [HttpGet("results")]
        public IActionResult Results()
        {
            string query = "SELECT * FROM teams";
            ViewBag.All= DbConnector.Query(query);
            // Accessin HTML with dict notation not dot notation
            return View();
        }

        // Create view to take in information from first form
        [HttpPost("create")]
        public IActionResult Create(string city, string name,int superbowls)
        {
            System.Console.WriteLine("came to create");
            string query = $@"INSERT INTO teams (city, name, superbowls, created_at, updated_at) VALUE ('{city}', '{name}', '{superbowls}', NOW(), NOW())";
            DbConnector.Execute(query);
            System.Console.WriteLine("model info sent to db");
            HttpContext.Session.SetString("last_city", $"{city}");
            HttpContext.Session.SetString("last_name", $"{name}");
            HttpContext.Session.SetInt32("last_sb", superbowls);
            return RedirectToAction("Index");
        }
 
        // Create view to take in information from second form.
        [HttpPost("create2")]
        public IActionResult Create2(Team team)
        {
            System.Console.WriteLine("came to create2");
            if (ModelState.IsValid)
            {
                System.Console.WriteLine("model is valid");
                string query = $@"INSERT INTO teams (city, name, superbowls, created_at, updated_at) VALUE ('{team.city}', '{team.name}', '{team.superbowls}', NOW(), NOW())";
                DbConnector.Execute(query);
                HttpContext.Session.SetString("last_city", $"{team.city}");
                HttpContext.Session.SetString("last_name", $"{team.name}");
                HttpContext.Session.SetInt32("last_sb", team.superbowls);
                HttpContext.Session.SetObjectAsJson("last_entry", team);
                return RedirectToAction("Index");
            }
            return View("Index", team);
        }
}
}