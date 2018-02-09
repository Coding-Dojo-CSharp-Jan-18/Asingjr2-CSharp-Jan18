using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using basic_db.Models;

namespace basic_db.Controllers
{
    public class HomeController : Controller
    {
        // GET: /Home/
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            // Create string query to be used by Query method of DBCONNECTOR that matches traditional SQL INSERT 
            string query = " SELECT * FROM quotes";
            ViewBag.Quotes = DbConnector.Query("SELECT * FROM quotes");
            // Can get single entry or use in different view to make id/name/content equal to form entry
            ViewBag.First = DbConnector.Query(query)[0];
            return View();
        }
        [HttpPost("post")]
        public IActionResult Post()
        {
            return RedirectToAction("Index");
        }
        [HttpPost("create")]
        public IActionResult Create(Quote quote)
        /* *************************************************
        Passing in quote object */
        {
            // Create string query to be used by execute method of DBCONNECTOR that matches traditional SQL INSERT 
            string query = $@"INSERT INTO quotes(author, content, created_at, updated_at) 
            VALUES ('{quote.author}', '{quote.content}', NOW(), NOW())";
            DbConnector.Execute(query);
            return RedirectToAction("Index");
        }
        [HttpPost("delete")]
        public IActionResult Delete(int id)
        {
            // Create delete query to be used by execute method of DBCONNECTOR that matches traditional SQL INSERT 
            string query = $"DELETE FROM quotes WHERE id = '{id}'";
            DbConnector.Execute(query);
            return RedirectToAction("Index");
        }
        [HttpPost("update")]
        public IActionResult Update(string author, string content, int id)
        {
            System.Console.WriteLine("came to update");
            string query = $"UPDATE quotes SET author = '{author}', content = '{content}', updated_at = NOW() WHERE id ='{id}'";
            DbConnector.Execute(query);
            return RedirectToAction("Index");
        }
        [HttpGet("show/{id}")]
        public IActionResult Show(int id)
        {
            ViewBag.User = DbConnector.Query($"SELECT * FROM quotes WHERE id = '{id}'")[0];
            return View();
        }
    }
}
