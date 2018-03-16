using GetAway.Models;
using GetAway.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GetAway.Controllers
{
    public class AdministratorsController : Controller
    {
        private ApplicationDbContext _context;

        public AdministratorsController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Administrators
        public ActionResult Index()
        {

            return View();
        }

        public ActionResult NewPackage()
        {
            return View();
        }

        
        // Needs validation for file type
        public ActionResult AddPackage(Package Package, HttpPostedFileBase PackagePicture1, HttpPostedFileBase PackagePicture2, HttpPostedFileBase PackagePicture3, HttpPostedFileBase PackagePicture4, HttpPostedFileBase PackagePicture5, HttpPostedFileBase PackagePicture6)
        {
            if (ModelState.IsValid)
            {
                if (PackagePicture1 != null)
                {
                    PackagePicture1.SaveAs(Server.MapPath("~/Images/Packages/") + PackagePicture1.FileName);
                    PackagePicture2.SaveAs(Server.MapPath("~/Images/Packages/") + PackagePicture2.FileName);
                    PackagePicture3.SaveAs(Server.MapPath("~/Images/Packages/") + PackagePicture3.FileName);
                    PackagePicture4.SaveAs(Server.MapPath("~/Images/Packages/") + PackagePicture4.FileName);
                    PackagePicture5.SaveAs(Server.MapPath("~/Images/Packages/") + PackagePicture5.FileName);
                    PackagePicture6.SaveAs(Server.MapPath("~/Images/Packages/") + PackagePicture6.FileName);

                    string path1 = Path.Combine(Server.MapPath("~/Images/Packages/"), Path.GetFileName(PackagePicture1.FileName));
                    string path2 = Path.Combine(Server.MapPath("~/Images/Packages/"), Path.GetFileName(PackagePicture2.FileName));
                    string path3 = Path.Combine(Server.MapPath("~/Images/Packages/"), Path.GetFileName(PackagePicture3.FileName));
                    string path4 = Path.Combine(Server.MapPath("~/Images/Packages/"), Path.GetFileName(PackagePicture4.FileName));
                    string path5 = Path.Combine(Server.MapPath("~/Images/Packages/"), Path.GetFileName(PackagePicture5.FileName));
                    string path6 = Path.Combine(Server.MapPath("~/Images/Packages/"), Path.GetFileName(PackagePicture6.FileName));

                    var pp1Path = "/Images/Packages/" + PackagePicture1.FileName;
                    var pp2Path = "/Images/Packages/" + PackagePicture2.FileName;
                    var pp3Path = "/Images/Packages/" + PackagePicture3.FileName;
                    var pp4Path = "/Images/Packages/" + PackagePicture4.FileName;
                    var pp5Path = "/Images/Packages/" + PackagePicture5.FileName;
                    var pp6Path = "/Images/Packages/" + PackagePicture6.FileName;

                    Package.PackagePicture1 = pp1Path;
                    Package.PackagePicture2 = pp2Path;
                    Package.PackagePicture3 = pp3Path;
                    Package.PackagePicture4 = pp4Path;
                    Package.PackagePicture5 = pp5Path;
                    Package.PackagePicture6 = pp6Path;

                }

                _context.Package.Add(Package);
            try
            {
                _context.SaveChanges();
            }
            catch (DbEntityValidationException dbve)
            {
                Console.WriteLine(dbve);
            }

        }
            return RedirectToAction("NewPackage");
    }

        public ActionResult NewHotel()
        {
            return View();
        }

        // Needs validation for file type
        public ActionResult AddHotel(Hotel Hotel, HttpPostedFileBase HotelPicture1, HttpPostedFileBase HotelPicture2, HttpPostedFileBase HotelPicture3, HttpPostedFileBase HotelPicture4, HttpPostedFileBase HotelPicture5, HttpPostedFileBase HotelPicture6)
        {
            if(ModelState.IsValid)
            {
                if(HotelPicture1 != null)
                {
                    HotelPicture1.SaveAs(Server.MapPath("~/Images/Hotels/") + HotelPicture1.FileName);
                    HotelPicture2.SaveAs(Server.MapPath("~/Images/Hotels/") + HotelPicture2.FileName);
                    HotelPicture3.SaveAs(Server.MapPath("~/Images/Hotels/") + HotelPicture3.FileName);
                    HotelPicture4.SaveAs(Server.MapPath("~/Images/Hotels/") + HotelPicture4.FileName);
                    HotelPicture5.SaveAs(Server.MapPath("~/Images/Hotels/") + HotelPicture5.FileName);
                    HotelPicture6.SaveAs(Server.MapPath("~/Images/Hotels/") + HotelPicture6.FileName);

                    string path1 = Path.Combine(Server.MapPath("~/Images/Hotels/"), Path.GetFileName(HotelPicture1.FileName));
                    string path2 = Path.Combine(Server.MapPath("~/Images/Hotels/"), Path.GetFileName(HotelPicture2.FileName));
                    string path3 = Path.Combine(Server.MapPath("~/Images/Hotels/"), Path.GetFileName(HotelPicture3.FileName));
                    string path4 = Path.Combine(Server.MapPath("~/Images/Hotels/"), Path.GetFileName(HotelPicture4.FileName));
                    string path5 = Path.Combine(Server.MapPath("~/Images/Hotels/"), Path.GetFileName(HotelPicture5.FileName));
                    string path6 = Path.Combine(Server.MapPath("~/Images/Hotels/"), Path.GetFileName(HotelPicture6.FileName));

                    var hp1Path = "/Images/Hotels/" + HotelPicture1.FileName;
                    var hp2Path = "/Images/Hotels/" + HotelPicture2.FileName;
                    var hp3Path = "/Images/Hotels/" + HotelPicture3.FileName;
                    var hp4Path = "/Images/Hotels/" + HotelPicture4.FileName;
                    var hp5Path = "/Images/Hotels/" + HotelPicture5.FileName;
                    var hp6Path = "/Images/Hotels/" + HotelPicture6.FileName;

                    Hotel.HotelPicture1 = hp1Path;
                    Hotel.HotelPicture2 = hp2Path;
                    Hotel.HotelPicture3 = hp3Path;
                    Hotel.HotelPicture4 = hp4Path;
                    Hotel.HotelPicture5 = hp5Path;
                    Hotel.HotelPicture6 = hp6Path;

                }

                _context.Hotel.Add(Hotel);
                try
                {
                    _context.SaveChanges();
                }
                catch (DbEntityValidationException dbve)
                {
                    Console.WriteLine(dbve);
                }

            }
            return RedirectToAction("NewHotel");
        }

        public ActionResult NewRoom()
        {
            var HotelList = _context.Hotel.ToList();
            var viewModel = new AddRoomViewModel
            {
                Hotel = HotelList
            };
            return View(viewModel);
        }

        // Needs validation for file type
        public ActionResult AddRoom(Room Room, HttpPostedFileBase rp1, HttpPostedFileBase rp2, HttpPostedFileBase rp3)
        {
            if(ModelState.IsValid)
            {
                if(rp1 != null)
                {
                    rp1.SaveAs(Server.MapPath("~/Images/Rooms/") + rp1.FileName);
                    rp2.SaveAs(Server.MapPath("~/Images/Rooms/") + rp2.FileName);
                    rp3.SaveAs(Server.MapPath("~/Images/Rooms/") + rp3.FileName);

                    string path1 = Path.Combine(Server.MapPath("~/Images/Rooms/"), Path.GetFileName(rp1.FileName));
                    string path2 = Path.Combine(Server.MapPath("~/Images/Rooms/"), Path.GetFileName(rp2.FileName));
                    string path3 = Path.Combine(Server.MapPath("~/Images/Rooms/"), Path.GetFileName(rp3.FileName));

                    var rp1Path = "/Images/Rooms/" + rp1.FileName;
                    var rp2Path = "/Images/Rooms/" + rp2.FileName;
                    var rp3Path = "/Images/Rooms/" + rp3.FileName;

                    Room.RoomPicture1 = rp1Path;
                    Room.RoomPicture2 = rp2Path;
                    Room.RoomPicture3 = rp3Path;
                    Room.RoomStatus = 0;
                }
                _context.Room.Add(Room);

                try
                {
                    _context.SaveChanges();
                }
                catch (DbEntityValidationException dbve)
                {
                    Console.WriteLine(dbve);
                }
            }

            return RedirectToAction("NewRoom");
        }
    }
}