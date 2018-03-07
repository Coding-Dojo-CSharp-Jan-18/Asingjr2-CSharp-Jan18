using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using bank.Models;

namespace bank.Controllers
{
    public class HomeController : Controller
    {
        private FullContext _cnx;
        public HomeController(FullContext context)
        {
            _cnx = context;
        }
        
        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("t")]
        public IActionResult t()
        {
            return View(_cnx.transactions.ToList());
        }

        [HttpGet("u")]
        public IActionResult u()
        {
            var u = _cnx.users.ToList();
            return View(u);
        }

        [HttpGet("a")]
        public IActionResult a()
        {
            return View();
        }
    
        [HttpGet("ua")]
        public IActionResult ua()
        {
            var ua = _cnx.useraccounts.ToList(); 
            return View(ua);
        }


        [HttpGet("reviews")]
        public IActionResult Reviews()
        {
            return View(_cnx.Reviews.ToList());
        }


    }
}
