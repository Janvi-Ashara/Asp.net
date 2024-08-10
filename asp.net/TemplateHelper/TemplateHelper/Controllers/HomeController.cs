
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TemplateHelper.Models;

namespace TemplateHelper.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            student s = new student();
            s.id = 1;
            s.fname = "janvi";
            s.lname = "ashara";
            s.city = "mumbai";
            s.dept = "mca";
            ViewBag.Message = "Your application description page.";
            return View(s);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}