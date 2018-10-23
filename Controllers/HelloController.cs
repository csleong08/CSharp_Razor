using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Razor.Controllers     //namespace!
{
    public class HelloController : Controller   //inheritance
    {
        [HttpGet]       
        [Route("")]     
        public IActionResult Index() // it will be string type if it's not routing
        {
            return View("index"); // "Hello World from HelloController!"
        }
    }
}