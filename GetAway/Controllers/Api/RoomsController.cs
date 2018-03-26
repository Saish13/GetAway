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
        [HttpGet]
        public IHttpActionResult GetRooms()
        {
            var roomDto = _context.Room.ToList().Select(Mapper.Map<Room, RoomDto>);
            return Ok(roomDto);
            //var roomDto = _context.Room.ToList().Select(Mapper.Map<Room, RoomDto>);
            //return Ok(roomDto);
        }

        [HttpGet]
        public IHttpActionResult GetAvaiableRooms(int id)
        {
            var roomDto = _context.Room.Where(r => (r.HotelID == id) && (r.RoomStatus == 0)).ToList().Select(Mapper.Map<Room, RoomDto>);
            return Ok(roomDto);
        }

        [HttpGet]
        public IHttpActionResult GetRoomType(int id)
        {
            var roomDto = _context.Room.Where(r => (r.HotelID == id) && (r.RoomStatus == 0)).
                GroupBy(r => r.RoomType, r => r.RoomRate).
                Select( r => new { RoomType = r.Key , RoomRate = r.ToList() });
            //r => new { RoomType = r.RoomType, RoomRate = r.RoomRate }


            return Ok(roomDto);
        }

        [HttpGet]
        public IHttpActionResult GetAvailableRoomId(int id)
        {
            var room = _context.Room.FirstOrDefault(r => (r.HotelID == id) && (r.RoomStatus == 0));
            //Select(r => new { RoomType = r.Key, RoomRate = r.ToList() });
            //r => new { RoomType = r.RoomType, RoomRate = r.RoomRate }
            return Ok(room);
        }

        [Route("api/rooms/GetRoomRate/{roomType}/{id}")]
        [HttpGet]
        public IHttpActionResult GetRoomRate(string roomType, int id)
        {
            var room = _context.Room.FirstOrDefault(r => (r.HotelID == id) && (r.RoomStatus == 0) && (r.RoomType.Contains(roomType)));
            //Select(r => new { RoomType = r.Key, RoomRate = r.ToList() });
            //r => new { RoomType = r.RoomType, RoomRate = r.RoomRate }
            return Ok(room);
        }

        // GET /api/room/1
        [HttpGet]
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
