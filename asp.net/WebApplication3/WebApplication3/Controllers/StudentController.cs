using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class StudentController : Controller
    {
        private object button1;
        private object button2;
        private object button3;

        //    List<Student> studentList = new List<Student>() {
        //                new Student(){ ID=1, Name="Steve", Dept ="MCA", City="Rajkot" },
        //                new Student(){ ID=2, Name="Bill", Dept= "MCA" ,City="Rajkot"},
        //                new Student(){ ID=3, Name="Ram",  Dept= "MCA", City="Rajkot" },
        //                new Student(){ ID=4, Name="Ron",  Dept ="MCA",City="Rajkot" },
        //                new Student(){ ID=5, Name="Rob",  Dept ="MCA",City="Rajkot" }
        //            };                                                                                                    
        // GET: Student    
        public ActionResult Index()
    {
        // Student s = new Student();
        //s.ID = 1;
        //s.Name = "janvi";
        //s.Dept = "MCA";
        //s.City = "Mumbai";
        // return View(s);

        var studentList = new List<Student>() {
                    new Student(){ ID=1, Name="Steve", Dept ="MCA", City="Rajkot" },
                    new Student(){ ID=2, Name="Bill", Dept= "MCA" ,City="Rajkot"},
                    new Student(){ ID=3, Name="Ram",  Dept= "MCA", City="Rajkot" },
                    new Student(){ ID=4, Name="Ron",  Dept ="MCA",City="Rajkot" },
                    new Student(){ ID=5, Name="Rob",  Dept ="MCA",City="Rajkot" }
                };

            ViewBag.Country = new List<String>() { "India", "Aus" };
            //  ViewBag.TotalStudents = studentList.Count();
            return View(studentList);
    }

        public ActionResult About()
        {
            ViewBag.Country = new List<String>() {"India","Aus" };
            return View();
      

        }
        public ActionResult Contact()
        {
           
            return View();
           
        }
        [HttpPost]
        //public ActionResult Contact(FormCollection f)
        public ActionResult Contact(int a, int b, string btn)

        {
            int ans = 0;
            if (btn == "sum")
            {
                ans = a + b;
            }
            else if (btn == "sub")
            {
                ans = a - b;
            }
            else if (btn == "mul")
            {
                ans = a * b;
            }
            else
            {
                ans = a / b;
            }
        
            ViewBag.f = ans;
            return View(ans);
            //{
            //    int ans = Convert.ToInt32(f[0]) + Convert.ToInt32(f[1]);
            //    ViewBag.f = ans;
            //}

           
        }
        public ActionResult MyCustomHelper()
        {
            return View();
        }
    }
}