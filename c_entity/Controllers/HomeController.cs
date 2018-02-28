using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using c_entity.Models;

namespace c_entity.Controllers
{
    public class HomeController : Controller
    {
        private UserContext _context;
        public HomeController(UserContext context)
        {
            _context = context;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            List<User> AllUsers = _context.Users.ToList();
            ViewBag.AU = AllUsers;
            User spEmail = _context.Users.SingleOrDefault( u => u.Email == "das1@d.com");
            ViewBag.SE = spEmail;
            // Adding to DB pretty straightforward process
            // User NewPerson = new User
            // {
            //     Name = "Brolly",
            //     Email = "goku@example.com",
            //     Password = "DBZ",
            // };
            // _context.Add(NewPerson);
            // _context.SaveChanges();
            User nameChange = _context.Users.Last(u => u.Password == "ff3");
            nameChange.Name = "NAME OF PASSWORD";
            _context.SaveChanges();
            // User ToDelete = _context.Users.SingleOrDefault(user => user.Id == 5);
            // _context.Users.Remove(ToDelete);
            // _context.SaveChanges();
            return View();
        }

        [HttpGet("test1")]
        public string Test1()
        {
            return "test1";
        }
    }
}
