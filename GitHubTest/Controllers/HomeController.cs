using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GitHubTest.Controllers
{
    public class HomeController : Controller
    {
        //this is issuefix branch
        public ActionResult Index()
        {
            return View();
        }
        //this is the second time from issuefix branch
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