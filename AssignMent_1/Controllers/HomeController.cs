using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AssignMent_1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index(string str)
        {
            string fileName = "~/sample" + ".pdf";
            if (str== "sample")
            {
                return File(fileName, "application/pdf");
            }
            else if (str== "gotoabout")
            {
                return RedirectToAction("About");
            }
            else if (str == "Login")
            {
                return View("Login");
            }
            else
            return Content("You entered:"+str,"text/plain");
        }

        public ActionResult About()
        {

            return Content("About content here", "text/plain");
        }
    }
}