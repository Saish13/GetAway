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
    public class RoomBookingController : ApiController
    {
        private ApplicationDbContext _context;

        public RoomBookingController()
        {
            _context = new ApplicationDbContext();
        }

        public IHttpActionResult GetRoomBooking()
        {
            var roomBookingDto = _context.RoomBooking.ToList().Select(Mapper.Map<RoomBooking, RoomBookingDto>);
            return Ok();
        }

        public IHttpActionResult GetRoomBooking(int id)
        {
            var roomBooking = _context.RoomBooking.SingleOrDefault(rb => rb.Id == id);
            if (roomBooking == null)
                return NotFound();
            return Ok(Mapper.Map<RoomBooking,RoomBookingDto>(roomBooking));
        }

        [HttpPost]
        public IHttpActionResult CreatePackageBooking(RoomBookingDto roomBookingDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var roomBooking = Mapper.Map<RoomBookingDto, RoomBooking>(roomBookingDto);
            _context.RoomBooking.Add(roomBooking);
            _context.SaveChanges();

            roomBookingDto.Id = roomBooking.Id;
            return Created(new Uri(Request.RequestUri + "/" + roomBooking.Id), roomBookingDto);
        }

        [HttpPut]
        public IHttpActionResult UpdateRoomBooking(int id, RoomBookingDto roomBookingDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var roomBookingInDb = _context.RoomBooking.SingleOrDefault(rb => rb.Id == id);

            if (roomBookingInDb == null)
                return NotFound();

            Mapper.Map(roomBookingDto, roomBookingInDb);
            _context.SaveChanges();

            return Ok();
        }

        [HttpDelete]
        public IHttpActionResult DeleteRoomBooking(int id)
        {
            var roomBookingInDb = _context.RoomBooking.SingleOrDefault(rb => rb.Id == id);
            if (roomBookingInDb == null)
                return NotFound();

            _context.RoomBooking.Remove(roomBookingInDb);
            _context.SaveChanges();

            return Ok();
        }
    }
}
