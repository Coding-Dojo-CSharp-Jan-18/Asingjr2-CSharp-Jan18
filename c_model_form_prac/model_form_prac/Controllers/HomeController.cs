using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using model_form_prac.Models;
using model_form_prac.Validators;

namespace model_form_prac.Controllers
{
    public class HomeController : Controller
    {
        // GET: /Home/
        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("create")]
        public IActionResult Create(Movie movie)
        {
            /* *************************************** */
            // INDIVIDUAL VALIDATION DONE IN CONTROLLER ******  Other option is to extend validator methods through a new class
            // if(movie.ReleaseDate > DateTime.Now)
            // {
            //     // Adding specific error message using model field and error message are arguements
            //     ModelState.AddModelError("ReleaseDate", "Date must be in the past");
            // }
            // return RedirectToAction("Index");
            if(ModelState.IsValid)
            {
                return Json(movie);
            }
            // Good practice to return form with actual data entered by the user!!!!!!  asp-validation shows errors
            return View("Index", movie);
        }
    }
}
