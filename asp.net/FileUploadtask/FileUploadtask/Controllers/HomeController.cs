using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FileUploadtask.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        public ActionResult FileUploadDemo()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        [HttpPost]
        public ActionResult FileUploadDemo(HttpPostedFileBase f)
        {
            string filename = f.FileName;
            string tp = f.ContentType.Split('/').First();
            string newnm = Guid.NewGuid().ToString() + "_" + filename;
            if (tp == "image")
            {
                f.SaveAs(Server.MapPath("~") + "//images//" + newnm);
            }
            else
            {
                ViewBag.err = "Error";
            }
            return View();
        }
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}