using AutoMapper;
using GetAway.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using GetAway.Dtos;

namespace GetAway.Controllers.Api
{
    public class HotelsController : ApiController
    {
        private ApplicationDbContext _context;

        public HotelsController()
        {
            _context = new ApplicationDbContext();
        }

        //GET /api/hotels
        public IHttpActionResult GetHotels()
        {
            var hotelDto = _context.Hotel.ToList().Select(Mapper.Map<Hotel, HotelDto>);
            return Ok(hotelDto);
        }

        public IHttpActionResult GetHotels(int id)
        {
            var hotel = _context.Hotel.SingleOrDefault(h => h.Id == id);

            if (hotel == null)
                return NotFound();

            return Ok(Mapper.Map<Hotel, HotelDto>(hotel));
        }

        // PUT /api/hotels/1
        [HttpPut]
        public IHttpActionResult UpdateHotels(int id, HotelDto hotelDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var hotelInDb = _context.Hotel.SingleOrDefault(h => h.Id == id);

            if (hotelInDb == null)
                return NotFound();

            Mapper.Map(hotelDto, hotelInDb);
            _context.SaveChanges();

            return Ok();
        }


        // DELETE /api/hotels/1
        [HttpDelete]
        public IHttpActionResult DeleteHotel(int id)
        {
            var hotelInDb = _context.Hotel.SingleOrDefault(h => h.Id == id);

            if (hotelInDb == null)
                return NotFound();

            _context.Hotel.Remove(hotelInDb);
            _context.SaveChanges();

            return Ok();
        }
    }
}
