using LearnCSharp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography;

namespace LearnCSharp.Controllers
{
    public class InstructorController : Controller
    {

        List<Instructor> InstructorList = new List<Instructor>() 
        { new Instructor() { 
            Id = 1, FirstName ="John ",LastName ="Doe",Rank = Ranks.Insturctor, HiringDate = DateTime.Now,
            isTenured = false,

        },new Instructor() {
             Id = 2,FirstName ="Josephy",LastName ="Doey",Rank = Ranks.AssistantProfessor, HiringDate = DateTime.Now,
             isTenured = true,

        },new Instructor() {
             Id = 3,FirstName ="Joe",LastName ="Doenny",Rank = Ranks.AssociateProfessor, HiringDate = DateTime.Now,
             isTenured = true,

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

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Instructor instructor)
        {
           // instructor.Id = RandomNumberGenerator.GetInt32(1000);
            InstructorList.Add(instructor);

            return View("Index",InstructorList);
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
