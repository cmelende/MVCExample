using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCExample.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View(new HomePageModel());
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

    public class HomePageModel
    {

        public string Header => "MVC Example";

        public string MainParagraph =>
            "Example repository for showing off different methods of the html helper and when and how to use them";
    }
}