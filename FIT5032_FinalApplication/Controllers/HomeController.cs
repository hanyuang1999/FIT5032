using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FIT5032_FinalApplication.Controllers
{
    [RequireHttps]
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

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Appointment()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Location()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Anxious()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Depression()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Eating()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }






    }
}