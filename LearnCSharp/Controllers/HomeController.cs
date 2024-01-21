using Microsoft.AspNetCore.Mvc;
using System.Dynamic;

namespace LearnCSharp.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            
            return Content("Home");
        }

        public string GetMe(int id) {

            return "";
        }
    }
}
