using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using cwall1.Models;

namespace cwall1.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            string query = $"SELECT * FROM USERS";
            ViewBag.All = DbConnector.Query(query);
            return View();
        }

        [HttpGet("register")]
        public IActionResult Register()
        {
            System.Console.WriteLine("came to register");
            return View();
        }

        [HttpGet("login")]
        public IActionResult Login()
        {
            System.Console.WriteLine("came to login");
            return View();
        }

        [HttpGet("wall")]
        public IActionResult Wall()
        {
            if (HttpContext.Session.GetInt32("id") == null)
                return RedirectToAction("Index");
            string query = @"SELECT messages.id AS mes, messages.message, messages.created_at, messages.updated_at
                    FROM messages
                    JOIN users
                    ON messages.users_id = users.id;";
            ViewBag.JMU = DbConnector.Query(query);
            string query2 = @"SELECT comments.id AS comm_id, comments.comment, comments.created_at, comments.updated_at, comments.messages_id
            FROM comments
            JOIN messages
            ON comments.messages_id = messages.id
            JOIN users
            ON messages.users_id = users.id";
            ViewBag.JCMU = DbConnector.Query(query2);
            WallViewModel wvm = new WallViewModel();
            return View();
        }

        [HttpPost("registerPost")]
        public IActionResult RegisterPost(User user)
        {
            System.Console.WriteLine("came to register post");
            string query = $"SELECT * FROM users WHERE email = '{user.email}'";
            if (DbConnector.Query(query).Count > 0)
                // Adding error to form location
                ModelState.AddModelError("email", "email already exists!!!!");
            System.Console.WriteLine($"email count is {DbConnector.Query(query).Count > 0}");

            if (ModelState.IsValid)
            {
                System.Console.WriteLine("model created");
                // Creating password hasher object that takes object
                PasswordHasher<User> hasher = new PasswordHasher<User>();
                // Creating hashed PW with model obect and string text
                string hashedPW = hasher.HashPassword(user, user.password);
                string query1 = $@"INSERT INTO users (first, last, email, password, created_at, updated_at) 
                    VALUES ('{user.first}', '{user.last}','{user.email}', '{hashedPW}', NOW(), NOW())";
                DbConnector.Execute(query1);
                return RedirectToAction("Index");
            }
            return View("Index", user);
        }

        [HttpPost("loginPost")]
        public IActionResult LoginPost(LogUser user)
        {
            // Check to see if user is in database...if query for database email is 0 no matches exist
            System.Console.WriteLine("came to loginPost");
            // string query to check DB agains email
            string login_query = $"SELECT * FROM users WHERE email = '{user.email}'";
            // Var to store search
            var userToLog = DbConnector.Query(login_query).FirstOrDefault();
            // test print to see if there are any results...email already unique
            System.Console.WriteLine(DbConnector.Query(login_query).Count);
            // test
            if (DbConnector.Query(login_query).Count == 0)
            {
                ModelState.AddModelError("email", "Invalid Email/Password");
                System.Console.WriteLine("password or email incorrect");
                return View("login", user);
            }
            // test against password
            else
            {
                {
                    // hashed from DB result of userToLog query result ran earlier
                    string hashedFromDB = (string)userToLog["password"];
                    PasswordHasher<LogUser> hasher = new PasswordHasher<LogUser>();
                    // Using VerifyPW function on hasher object that takes object, hashed info, comparison password
                    //  Below item utilizes enum to change string to int value for easy validation
                    if (hasher.VerifyHashedPassword(user, hashedFromDB, user.password) == 0)
                    {
                        // Result if password is incorrect
                        // Best to create tempdata comment that says generic user or password wrong for safety!!!
                        ModelState.AddModelError("password", "Invalid Email/Password");
                        return View("login", user);
                    }
                    System.Console.WriteLine(hasher.VerifyHashedPassword(user, hashedFromDB, user.password));
                }
            }
            if (ModelState.IsValid)
            {
                //  Log User IN
                HttpContext.Session.SetInt32("id", (int)userToLog["id"]);
                TempData["success"] = "You have logged in successfully";
                return RedirectToAction("Wall");
            }
            // return view if not successful goes back to index where form is
            return RedirectToAction("index", user);
        }

        [HttpPost("messagePost")]
        public IActionResult MessagePost(string message)
        // Hardcoded user id
        {
            int userId = (int)HttpContext.Session.GetInt32("id");
            if( message.Length > 0)
            {
                string query1 = $@"INSERT INTO messages (message, created_at, updated_at, users_id) 
                    VALUES ('{message}',NOW(), NOW(),'{userId}')";
                DbConnector.Execute(query1);
                System.Console.WriteLine("message submitted");
            }
            return RedirectToAction("Wall");
        }

        [HttpPost("commentPost")]
        public IActionResult CommentPost(string comment, string mes_id)
        // Hardcoded user id
        {
            System.Console.WriteLine("came to commentPost");
            System.Console.WriteLine(comment);
            if (comment.Length > 0)
            {
                string query1 = $@"INSERT INTO comments (comment, created_at, updated_at, messages_id, users_id) 
                    VALUES ('{comment}',NOW(), NOW(),'{mes_id}','3')";
                DbConnector.Execute(query1);
                System.Console.WriteLine("comment submitted");
            }
            return RedirectToAction("Wall");
        }
        [HttpGet("logout")]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            System.Console.WriteLine(HttpContext.Session.GetInt32("id"));
            return RedirectToAction("Index");
        }
    }
}
