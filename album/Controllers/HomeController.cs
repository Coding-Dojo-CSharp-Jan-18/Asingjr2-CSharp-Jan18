using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using album.Models;

namespace album.Controllers
{
    public class HomeController : Controller
    {
        private FullContext cnx;
        public HomeController(FullContext context)
        {
            cnx = context;
        }

        [HttpGet("artists")]
        public IActionResult Artists()
        {
            ViewBag.ARTISTS = cnx.artists.ToList();
            return View();
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            // creating variable containing db results for albums
            ViewBag.ALBUMS = cnx.albums.ToList();
            return View();
        }


    }
}
