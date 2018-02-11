using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using model_forms.Models;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace model_forms.Controllers
{
    public class HomeController : Controller
    {
        // GET: /Home/
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            Friend Barry = new Friend()
            {
                Name = "Barry",
                Color = "Yellow",
                Email = "zoo@d.com"
            };
            IndexViewModel model = new IndexViewModel()
            {
                MyFriend = Barry,
                Friends = Friend.GetFriends(),
                Message = "Hello Clarice" 
            };
            // return View(Barry);
            // View takes two optional arguements...a cshtml file and a model
            return View(model);
            /* ********************************************
            Take away is that you can only pass one model through View function, however, you can make a class object that take models as properties and then call them as @Model.attribute1 or Model.attribute1._second_model_attributes 
            
            -YES!!! -dev
            
            */
        }
        [HttpGet("createfriend")]
        public IActionResult CreateFriend()
        {
            // Can send new empty friend object so that the form know specifically what model objects to reference
            Friend Barry2 = new Friend()
            {
                Name = "Barry",
                Color = "Yellow",
                Email = "zoo@d.com"
            };
                // return View(new Friend());
                return View(Barry2);
            /* ************************************************
            Can pass model as argument to autopopulate fields as long as asp-for inputs are present  ************************************************* */
        }

        [HttpPost("create")]
        public IActionResult Create(Friend friend)
        {
            // Manual error check for first letter of field entry
            if(friend.Color[0] == 'M')
            // Can create custom validations with AddModelError(_Model, _Message)
                ModelState.AddModelError("Color", "Manual entered message");
            // Giving direction based on model state valdity
            if(ModelState.IsValid)
            {
                System.Console.WriteLine("model is valid");
                return Json(friend);
            }
            // If model is not valid we return view and model errors with the validation spans in form 
            return View("CreateFriend", friend);
        }
    }
}
