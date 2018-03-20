using GetAway.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GetAway.ViewModels;

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
            Package package = new Package() { Id = id };
               
            return View(package);
        }

        [Route("Packages/ViewPackage/{id}/BookingDetails")]
        [Authorize]
        public ActionResult BookingDetails(int id)
        {
            
            ApplicationUser user = System.Web.HttpContext.Current.GetOwinContext().GetUserManager<ApplicationUserManager>().FindById(System.Web.HttpContext.Current.User.Identity.GetUserId());
            Package package = new Package() { Id = id };
            var viewModel = new BookingDetailsViewModel()
            {
                User = user,
                Package = package
            };
            return View(viewModel);
        }
    }
}