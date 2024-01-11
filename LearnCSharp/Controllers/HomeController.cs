using Microsoft.AspNetCore.Mvc;
using System.Dynamic;

namespace LearnCSharp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            int x  = 3 + 1 * 5 / 2;
            return Content(x.ToString());
        }

        public string GetMe(int id) {

            return "Moises Msukwa";
        }
    }
}
