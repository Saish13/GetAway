using AutoMapper;
using GetAway.Dtos;
using GetAway.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace GetAway.Controllers.Api
{
    public class PackageBookingController : ApiController
    {
        private ApplicationDbContext _context;

        public PackageBookingController()
        {
            _context = new ApplicationDbContext();
        }

        // GET /api/packagebooking
        public IHttpActionResult GetPackageBooking()
        {
            var packageBookingDto = _context.PackageBooking.ToList().Select( Mapper.Map<PackageBooking,PackageBookingDto>);
            return Ok(packageBookingDto);
        }

        public IHttpActionResult GetPackageBooking(int id)
        {
            var packageBooking = _context.PackageBooking.SingleOrDefault(pb => pb.Id == id);

            if (packageBooking == null)
                return BadRequest();

            return Ok(Mapper.Map<PackageBooking, PackageBookingDto>(packageBooking));
        }

        [HttpPost]
        public IHttpActionResult CreatePackageBooking(PackageBookingDto packageBookingDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var packageBooking = Mapper.Map<PackageBookingDto, PackageBooking>(packageBookingDto);
            _context.PackageBooking.Add(packageBooking);
            _context.SaveChanges();

            packageBookingDto.Id = packageBooking.Id;
            return Created(new Uri(Request.RequestUri + "/" + packageBooking.Id), packageBookingDto);
        }

        [HttpPut]
        public IHttpActionResult UpdatePackageBooking(int id, PackageBookingDto packageBookingDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var packageBookingInDb = _context.PackageBooking.SingleOrDefault(pb => pb.Id == id);

            if (packageBookingInDb == null)
                return NotFound();

            Mapper.Map(packageBookingDto, packageBookingInDb);
            _context.SaveChanges();

            return Ok();
        }

        [HttpDelete]
        public IHttpActionResult DeleteBookingPackage(int id)
        {
            var packageBookingInDb = _context.PackageBooking.SingleOrDefault(pb => pb.Id == id);

            if (packageBookingInDb == null)
                return NotFound();

            _context.PackageBooking.Remove(packageBookingInDb);
            _context.SaveChanges();

            return Ok();
        }
    }
}
