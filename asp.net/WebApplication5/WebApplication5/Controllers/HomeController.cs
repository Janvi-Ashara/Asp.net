using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication5.Models;

namespace WebApplication5.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Student s = new Student();
            return View(s);
        }
        [HttpPost]
        public ActionResult Index(Student s)
        {
            ViewBag.f = s.fname;
            ViewBag.l = s.lname;
            ViewBag.a = s.add;
            ViewBag.g = s.gender;
            ViewBag.c = s.city;
            return View(s);
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
    }
}