using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace c_first_app
{
    public class HelloController : Controller
    {
        [HttpGet("index")]
        public string Index()
        {
            return "Hello World";
        }

        // [HttpPost]
        // [Route("")]
        // public IActionResult Other()
        // {
        // }

        // URL PARAMs
        //[Route("template/{Name}")]
        // public IActionResult Method(string Name)
        // Try to return JSON
        [HttpGet("jj")]
        public JsonResult Example()
        {
            return Json(154);
        }

        // Anonymous Object Route
        [HttpGet("anon")]
        public JsonResult DisplayInt()
        {
            var Annon = new {
                FirstName="Rax",
                LastName="Aqu",
                Age = 11
            };
            return Json(Annon);
        }
    }
}