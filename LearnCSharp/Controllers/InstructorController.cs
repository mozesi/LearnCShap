using LearnCSharp.Models;
using LearnCSharp.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Security.Cryptography;

namespace LearnCSharp.Controllers
{
    public class InstructorController : Controller
    {

        private readonly IMyFakeDataService _fakeData;

        public InstructorController(IMyFakeDataService fakeData) { 
        _fakeData = fakeData;
        }
        public IActionResult Index()
        {
            return View(_fakeData.Instructors);
        }
        public IActionResult ShowAll()
        {
            return View();  
        }
        public IActionResult DisplayAll()
        {
            return View("index", _fakeData.Instructors);
        }
        public IActionResult ShowDetails(int id)
        {
            Instructor? instructor = _fakeData.Instructors.FirstOrDefault(instructor => instructor.Id == id);
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
            _fakeData.Instructors.Add(instructor);

            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            Instructor? instructor = _fakeData.Instructors.FirstOrDefault(instructor=>instructor.Id == id);

            if (instructor != null)
                return View(instructor);
            return NotFound();
        }

        [HttpPost]
        public IActionResult Edit(Instructor instructorChanges) {
            Instructor? instructor = _fakeData.Instructors.FirstOrDefault(instructor => instructor.Id == instructorChanges.Id);

            if (instructor != null) {
                instructor.LastName = instructorChanges.LastName;
                instructor.isTenured = instructorChanges.isTenured;
                instructor.HiringDate = instructorChanges.HiringDate;
                instructor.Rank = instructorChanges.Rank;
            }
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            return View();
        }
    }
}
