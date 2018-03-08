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
            var a = _cnx.accounts.ToList();
            return View();
        }

        [HttpGet("au")]
        public IActionResult au()
        {
            var au = _cnx.accounts.Include(us => us.accountInfo).ThenInclude( o => o.Person).ToList();
            return View(au);
        }


        [HttpGet("ua")]
        public IActionResult ua()
        {
            var ua = _cnx.useraccounts.ToList(); 
            return View(ua);
        }


   

    }
}
