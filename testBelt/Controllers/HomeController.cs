using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using testBelt.Models;

namespace testBelt.Controllers
{
    public class HomeController : Controller
    {
        private FullContext _c;
        public HomeController(FullContext context)
        {
            _c = context;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("users")]
        public IActionResult Users()
        {
            return View(_c.Users.ToList());
        }

        [HttpGet("games")]
        public IActionResult Games()
        {
            return View(_c.Games.Include( f => f.owner).ToList());
        }

        [HttpGet("characters")]
        public IActionResult Characters()
        {
            return View(_c.Characters.Include( d => d.heroGames).ToList());
        }

        [HttpGet("gameCharacters")]
        public IActionResult GameCharacters()
        {
            System.Console.WriteLine("Hello Moto");
            var gameCharacterSet = _c.Games
            .Include(h => h.heroChoices)
            .ThenInclude(cc => cc.coolCharacter)
            .ToList();           
            return View();
        }
    }
}
