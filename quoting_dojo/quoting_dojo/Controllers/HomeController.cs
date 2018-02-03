using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace quoting_dojo.Controllers
{
    public class HomeController : Controller
    {
        // GET: /Home/
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            string allQuotes = "SELECT * FROM quotes";
            var quotes = DbConnector.Query(allQuotes);
            if(quotes != null)
            {
                ViewBag.AQ = quotes;
            }
            else
            {
                string noQuotes = "No Quotes Yet!!!!";
                ViewBag.AQ = noQuotes;
            }
            return View();
        }

        [HttpGet("/quotes")]
        public IActionResult Quotes()
        {
            return RedirectToAction("Index");
        }

        [HttpPost("/post")]
        public IActionResult Post(string author, string content, string typee)
        {
            switch(typee)
            {
                case "form1":
                    System.Console.WriteLine("this was form1");
                    break;

                default: 
                System.Console.WriteLine("this was form2");
                break;
            }
            string addQuote = $"INSERT INTO quotes (author, content, created_at, updated_at) VALUE ('{author}', '{content}', now(), now())";
            DbConnector.Execute(addQuote);
            return RedirectToAction("Index");
        }

        [HttpGet("/errors")]
        public IActionResult Error()
        {
            return View();
        }
    }
}
