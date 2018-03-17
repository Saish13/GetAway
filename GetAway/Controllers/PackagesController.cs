using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GetAway.Controllers
{
    public class PackagesController : Controller
    {
        // GET: Packages
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ListPackages()
        {
            return View();
        }
        public ActionResult ViewPackage(int id)
        {
            return View();
        }
    }
}