using BlogApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogApplication.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ViewResult Index(int? id)
        {
            //ViewData["value"] = id;
            //ViewBag.Message = "Hello";

            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            Student s = new Student
            {
                Name = "Michalis",
                Surname = "Nikolaidis"
            };

            IndexViewModel vm = new IndexViewModel
            {
                Student = s,
                Numbers = numbers
            };

            return View(vm);
        }

        public string Index2()
        {
            return "Index2";
        }
    }
}