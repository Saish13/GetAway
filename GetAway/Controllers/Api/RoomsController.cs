using AutoMapper;
using GetAway.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using GetAway.Dtos;
using System.Data.Entity;

namespace GetAway.Controllers.Api
{
    public class RoomsController : ApiController
    {
        private ApplicationDbContext _context;

        public RoomsController()
        {
            _context = new ApplicationDbContext();
        }

        // GET /api/rooms
        public IHttpActionResult GetRooms()
        {
            var roomDto = _context.Room.SqlQuery("Select * from Room;").ToList().Select(Mapper.Map<Room, RoomDto>);
            return Ok(roomDto);
            //var roomDto = _context.Room.ToList().Select(Mapper.Map<Room, RoomDto>);
            //return Ok(roomDto);
        }

        [HttpGet]
        public IHttpActionResult GetAvaiableRooms(int id)
        {
            byte EmpytRoom = 0;
            var query = "select RoomType from Rooms where HotelId = '" + id + "' and RoomStatus = '" + EmpytRoom + "' group by RoomType;";
            var roomDto = _context.Room.SqlQuery(query).ToList().Select(Mapper.Map<Room, RoomDto>);
            return Ok(roomDto);
        }

        // GET /api/room/1
        public IHttpActionResult GetRoom(int id)
        {
            var room = _context.Room.SingleOrDefault(r => r.Id == id);

            if (room == null)
                return NotFound();

            return Ok(Mapper.Map<Room, RoomDto>(room));
        }

        // PUT /api/room/1
        [HttpPut]
        public IHttpActionResult UpdateRoom(int id, RoomDto roomDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var roomInDb = _context.Room.SingleOrDefault(r => r.Id == id);

            if (roomInDb == null)
                return NotFound();

            Mapper.Map(roomDto, roomInDb);
            _context.SaveChanges();

            return Ok();
        }

        [HttpDelete]
        public IHttpActionResult DeleteRoom(int id)
        {

            var roomInDb = _context.Room.SingleOrDefault(r => r.Id == id);

            if (roomInDb == null)
                return NotFound();

            _context.Room.Remove(roomInDb);
            _context.SaveChanges();

            return Ok();
        }
    }
}
