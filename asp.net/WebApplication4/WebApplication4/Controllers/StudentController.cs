using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication4.Models;

namespace WebApplication4.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            Student st = new Student();
            st.ID = 1;
            st.Name = "Reesha";
            return View(st);
        }
        public ActionResult About()
        {
            ViewBag.Country = new List<String>() { "india", "USA" };
            return View();
        }
        public ActionResult Contact()
        {
            return View();
        }
    }
}