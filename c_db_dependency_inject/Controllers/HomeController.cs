using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

using c_db_dependency_inject.Models;


namespace c_db_dependency_inject.Controllers
{
    public class HomeController : Controller
    {
        private DbConnector  _dbConnector;
        public HomeController(DbConnector dbConnector)
        {
            _dbConnector = dbConnector;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            System.Console.WriteLine("came to index");
            // Create string query to be used by Query method of DBCONNECTOR that matches traditional SQL INSERT 
            // string query = " SELECT * FROM quotes";
            // ViewBag.Quotes = _dbConnector.Query("SELECT * FROM quotes");
            // // Can get single entry or use in different view to make id/name/content equal to form entry
            // ViewBag.First = _dbConnector.Query(query)[0];
            return View();
        }

        [HttpPost("post")]
        public IActionResult Post()
        {
            System.Console.WriteLine("came to post");
            return RedirectToAction("Index");
        }

        [HttpPost("create")]
        public IActionResult Create(Quote quote)
        /* *************************************************
        Passing in quote object */
        {
            // Create string query to be used by execute method of _dbConnector that matches traditional SQL INSERT 
            string query = $@"INSERT INTO quotes(author, content, created_at, updated_at) 
            VALUES ('{quote.author}', '{quote.content}', NOW(), NOW())";
            _dbConnector.Execute(query);
            return RedirectToAction("Index");
        }

        [HttpPost("delete")]
        public IActionResult Delete(int id)
        {
            // Create delete query to be used by execute method of _dbConnector that matches traditional SQL INSERT 
            string query = $"DELETE FROM quotes WHERE id = '{id}'";
            _dbConnector.Execute(query);
            return RedirectToAction("Index");
        }
        [HttpPost("update")]
        public IActionResult Update(string author, string content, int id)
        {
            System.Console.WriteLine("came to update");
            string query = $"UPDATE quotes SET author = '{author}', content = '{content}', updated_at = NOW() WHERE id ='{id}'";
            _dbConnector.Execute(query);
            return RedirectToAction("Index");
        }
        [HttpGet("show/{id}")]
        public IActionResult Show(int id)
        {
            ViewBag.User = _dbConnector.Query($"SELECT * FROM quotes WHERE id = '{id}'")[0];
            return View();
        }

  
    }
}
