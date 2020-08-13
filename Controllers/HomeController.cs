using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Gearhead.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            dynamic Home = ViewBag.Title;
            return View();
        }

        public ActionResult Engine()
        {
            dynamic Engine = ViewBag.Title;
            return View();
        }

        public ActionResult Fuelsystem()
        {
            return View();
        }

        public ActionResult Safety()
        {
            return View();
        }

        public ActionResult Ignitionsystem()
        {
            return View();
        }

        public ActionResult Drivetrain()
        {
            return View();
        }
        public ActionResult Suspension()
        {
            return View();
        }

        public ActionResult Brakesystem()
        {
            return View();
        }
    }


}