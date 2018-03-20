using GetAway.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

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
    }
}