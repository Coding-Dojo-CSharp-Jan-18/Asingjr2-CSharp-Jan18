using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using appsettings;


namespace appsettings.Controllers
{
    public class HomeController : Controller
    {
        // GET: /Home/
        private readonly DbConnector _dbConnector;

        public HomeController(DbConnector connect)
        {
            _dbConnector = connect;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            List<Dictionary<string, object>> Quotes = _dbConnector.Query("SELECT * FROM quotes");
            ViewBag.AQ = Quotes;
            _dbConnector.Query("DELETE FROM QUOTES WHERE id='12'");
            return View();
            // Other code
        }
    }
}
