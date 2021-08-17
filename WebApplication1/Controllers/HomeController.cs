using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;
using WebApplication1.ViewModels;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {

            //ViewBag.Name = "adam";
            //ViewBag.Surname = "saasa";
            //TempData["Age"] = 25;
            //return RedirectToAction(nameof(Test));
            string fullname = "Ehmed Memmed";
            List<int> numbers = new List<int> { 1,2,3,4,5};
            List<Student> students = new List<Student>
            {
                 new Student{Id=1,Name="kama",Surname="muro"},
                new Student{Id=2,Name="ada",Surname="muaaro"},
                new Student{Id=3,Name="assda",Surname="mussaaro"}
            };


            HomeViewModel model = new HomeViewModel
            {

                Students=students,
                Numbers = numbers,
                Fullname = fullname,


            };
            return View(model);
        }

        public IActionResult Test()
        {
            return View();
        }
    }
}
