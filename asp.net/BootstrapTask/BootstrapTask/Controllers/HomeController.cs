using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BootstrapTask.Models;

namespace BootstrapTask.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var studentList = new List<Student>() {
                    new Student(){ ID=1, Name="Steve", Dept ="MCA", City="Rajkot",Age=23},
                    new Student(){ ID=2, Name="Bill", Dept= "MCA" ,City="Rajkot",Age=28},
                    new Student(){ ID=3, Name="Ram",  Dept= "MCA", City="Rajkot",Age=21 },
                    new Student(){ ID=4, Name="Ron",  Dept ="MCA",City="Rajkot",Age=22 },
                    new Student(){ ID=5, Name="Rob",  Dept ="MCA",City="Rajkot",Age=20 },
                    new Student(){ ID=6, Name="Steve", Dept ="MCA", City="Rajkot",Age=23},
                    new Student(){ ID=7, Name="Bill", Dept= "MCA" ,City="Rajkot",Age=28},
                    new Student(){ ID=8, Name="Ram",  Dept= "MCA", City="Rajkot",Age=21 },
                    new Student(){ ID=9, Name="Ron",  Dept ="MCA",City="Rajkot",Age=22 },
                    new Student(){ ID=10, Name="Rob",  Dept ="MCA",City="Rajkot",Age=20 }
                };

            ViewBag.Country = new List<String>() { "India", "Aus" };
            //  ViewBag.TotalStudents = studentList.Count();
            return View(studentList);
        }
        public ActionResult MyView()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Service()
        {
            ViewBag.Message = "Your Service page.";

            return View();
        }
        public ActionResult Portfolio()
        {
            ViewBag.Message = "Your Service page.";

            return View();
        }
    }
}