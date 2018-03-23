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
    public class HotelsController : Controller
    {
        // GET: Hotels
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ListHotels()
        {
            return View();
        }
        public ActionResult ViewHotel(int id)
        {
            Hotel hotel = new Hotel() { Id = id }; 
            return View(hotel);
        }

        [Route("Hotels/ViewHotel/{id}/BookingDetails")]
        [Authorize]
        public ActionResult BookingDetails(int id)
        {
            ApplicationUser user = System.Web.HttpContext.Current.GetOwinContext().GetUserManager<ApplicationUserManager>().FindById(System.Web.HttpContext.Current.User.Identity.GetUserId());
            Hotel hotel = new Hotel() { Id = id };
            var viewModel = new HotelBookingDetailsViewModel
            {
                User = user,
                Hotel = hotel
            };
            return View(viewModel);
        }
    }
}