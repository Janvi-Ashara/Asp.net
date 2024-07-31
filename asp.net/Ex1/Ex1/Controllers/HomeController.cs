using Ex1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ex1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            Student std = new Student();
            std.ID = 1;
            std.Name = "Ravi";
            std.Address = "Rajkot";
            return View(std);
        }
        public ActionResult About()
        {
            return View();
        }
    }
}