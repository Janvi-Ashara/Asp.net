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
        MydbEntities db = new MydbEntities();
        // GET: Student
        public ActionResult Index()
        {

            List<student> stds = db.students.ToList();
            return View(stds);
        }
        public ActionResult Registration(int? id)
        {
            student std = db.students.Find(id);
            return View(std);
        }
        [HttpPost]
        public ActionResult Registration(student s)
        {
            if (s.Id != 0)
            {
                student std = db.students.Find(s.Id);
                std.fname = s.fname;
                std.lname = s.lname;
                std.dept = s.dept;
            }
            else
            {
                db.students.Add(s);
            }
            db.SaveChanges();
            return RedirectToAction("Index");

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