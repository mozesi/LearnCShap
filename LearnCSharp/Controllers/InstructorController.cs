using LearnCSharp.Models;
using Microsoft.AspNetCore.Mvc;

namespace LearnCSharp.Controllers
{
    public class InstructorController : Controller
    {

        List<Instructor> InstructorList = new List<Instructor>() 
        { new Instructor() { 
            Id = 1, FirstName ="John ",LastName ="Doe",Rank = Ranks.Insturctor, HiringDate = DateTime.Now,

        },new Instructor() {
             Id = 2,FirstName ="Josephy",LastName ="Doey",Rank = Ranks.Insturctor, HiringDate = DateTime.Now,

        },new Instructor() {
             Id = 3,FirstName ="Joe",LastName ="Doenny",Rank = Ranks.Insturctor, HiringDate = DateTime.Now,

        }
        };
        public IActionResult Index()
        {
            return View(InstructorList);
        }
        public IActionResult ShowAll()
        {
            return View();  
        }
        public IActionResult DisplayAll()
        {
            return View("index", InstructorList);
        }
        public IActionResult ShowDetails(int id)
        {
            Instructor? instructor = InstructorList.FirstOrDefault(instructor => instructor.Id == id);
            if (instructor != null)
                return View(instructor);
            return NotFound();
        }
        public IActionResult Add()
        {
            return View();
        }
        public IActionResult Edit(int id)
        {
            return View();
        }
        public IActionResult Delete(int id)
        {
            return View();
        }
    }
}
