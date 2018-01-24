using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FormController.Controllers
{
    public class FormController : Controller
    {
        // Basic Index Route
        [HttpGet("")]
        // Function name must match cshtml file or you can say View("file_name.cshtml")
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet("random1")]
        // Function name must match cshtml file or you can say View("file_name.cshtml")
        public IActionResult Random1()
        {
            return View();
        }
        //Url
        //Url param....no backslash needed for first part..simple display of url info using viewbag
        [HttpGet("{word}")]
        public IActionResult Word(string word)
        {
            string random_word = word;
            ViewBag.Word = random_word;
            return View();
        }
        // [HttpPost("create")]
        // public IActionResult Create(string name, string color)
        // {
        //     object form_info = new {
        //         form_name = name, 
        //         form_color = color
        //     };
        //     return Json(form_info);
        // }

    }
}
