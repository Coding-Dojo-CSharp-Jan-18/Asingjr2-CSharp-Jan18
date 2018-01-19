using Microsoft.AspNetCore.Mvc;

namespace calling_card.controllers
{
    public class CallingController : Controller 
    {
        [HttpGet]
        [Route("display/{fn}/{ln}/{age}/{color}")]
        public JsonResult Display(string fn,string ln, int age, string color)
        {
            var group_info = new {
                fn = fn,
                ln = ln,
                age = age,
                color = color
            };
            return Json(group_info);
        }
    };
    }



