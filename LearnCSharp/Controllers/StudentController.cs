﻿using LearnCSharp.Models;
using Microsoft.AspNetCore.Mvc;

namespace LearnCSharp.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index() 
        {
            return Content("INdex");
        }
        public IActionResult ShowDetails(int id) {

            Student std = new Student();
            std.FirstName = "Moses";
            std.LastName = "Msukwa";

            ViewBag.student = std;
            return View();
        }
    }
}
