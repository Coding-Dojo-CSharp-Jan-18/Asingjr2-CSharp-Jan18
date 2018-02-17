using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using user_auth.Models;

namespace user_auth.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("register")]
        public IActionResult Register(User user)
        {
            string query = $"SELECT * FROM users WHERE email = '{user.email}'";
            if(DbConnector.Query(query).Count>0)
                // Adding error to form location
                ModelState.AddModelError("email", "email already exists!!!!");
            System.Console.WriteLine(DbConnector.Query(query).Count > 0);

            if(ModelState.IsValid)
            {
                System.Console.WriteLine("model created");
                // Creating hashed password
                string tempPW = "secret";
                // Creating password hasher object that takes object
                PasswordHasher<User> hasher = new PasswordHasher<User>();
                // Creating string with form model being used and specific field where unhashed pw was entered;
                string hashedPW = hasher.HashPassword(user, user.password);
                System.Console.WriteLine(tempPW);
                System.Console.WriteLine(hasher);
                System.Console.WriteLine(hashedPW);
                string query1 = $@"INSERT INTO users (first, last, email, password, confirm) 
                    VALUES ('{user.first}', '{user.last}','{user.email}', '{hashedPW}', '{hashedPW}')";
                DbConnector.Execute(query1);
                return RedirectToAction("Index");
            }
            return View("Index");
        }

        [HttpGet("login")]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost("loginPost")]
        public IActionResult LoginPost(LogUser user)
        {
            // Check to see if user is in database...if query for database email is 0 no matches exist
            System.Console.WriteLine("came to loginPost");
            string login_query = $"SELECT * FROM users WHERE email = '{user.email}'";
            var userToLog = DbConnector.Query(login_query).FirstOrDefault();
            System.Console.WriteLine(login_query);
            if (DbConnector.Query(login_query).Count == 0)
                ModelState.AddModelError("email", "Invalid Email/Password");
            else
            {
                {
                    // hashed from DB result of userToLog query result ran earlier
                    string hashedFromDB = (string)userToLog["password"];
                    PasswordHasher<LogUser> hasher = new PasswordHasher<LogUser>();
                    // Using VerifyPW function on hasher object that takes object, hashed info, comparison password
                    //  Below item utilizes enum to change string to int value for easy validation
                    if(hasher.VerifyHashedPassword(user, hashedFromDB, user.password) == 0)
                    {
                        // Result if password is incorrect
                        ModelState.AddModelError("email", "Invalid Email/Password");
                    }
                }
            }
            if(ModelState.IsValid)
            {
                //  Log User IN
                HttpContext.Session.SetInt32("id", (int)userToLog["id"]);
                TempData["success"] = "You have logged in successfully";
                return RedirectToAction("Success");
            }

            return RedirectToAction("Index");
        }

        [HttpGet("success")]
        public IActionResult Success()
        {
            return View();
        }
    }
}
