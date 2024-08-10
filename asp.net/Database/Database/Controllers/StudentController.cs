using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Database.Models;

namespace Database.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            MydbEntities db = new MydbEntities();
            List<student> stds = db.students.ToList();
            return View(stds);
        }
         public ActionResult Registration()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Registration(student s)
        {
            MydbEntities db = new MydbEntities();
            db.students.Add(s);
            db.SaveChanges();
            return RedirectToAction("Index");
            return View();
        }
        public ActionResult delete(int Id)
        {
            MydbEntities db = new MydbEntities();
            student stu = db.students.Find(Id);
            db.students.Remove(stu);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}