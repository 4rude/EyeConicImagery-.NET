using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EC_MVC.Controllers
{
    //[RequireHttps]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "About the EyeConic Team";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Querys? Quibbles? Concerns? Complaints?";

            return View();
        }

        public ActionResult Works()
        {
            ViewBag.Message = "Welcome to our gallery of works";

            return View();
        }

        public ActionResult OrderSubmit()
        {
            ViewBag.Message = "Submit an order for our EyeConic team to process";

            return View();
        }
    }
}