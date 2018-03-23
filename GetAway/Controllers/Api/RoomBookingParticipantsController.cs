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
    public class RoomBookingParticipantsController : ApiController
    {
        private ApplicationDbContext _context;
        public RoomBookingParticipantsController()
        {
            _context = new ApplicationDbContext();
        }

        // GET /api/...
        [HttpGet]
        public IHttpActionResult GetParticipants(int id)
        {
            var roomParticipant = _context.RoomBookingParticipants.ToList().Where(rbp => rbp.Id == id).Select(Mapper.Map<RoomBookingParticipants, RoomBookingParticipantsDto>);
            return Ok(roomParticipant);
        }

        [HttpPost]
        public IHttpActionResult CreateParticipants(RoomBookingParticipantsDto participantsDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var participant = Mapper.Map<RoomBookingParticipantsDto, RoomBookingParticipants>(participantsDto);
            _context.RoomBookingParticipants.Add(participant);
            _context.SaveChanges();

            participantsDto.Id = participant.Id;
            return Created(new Uri(Request.RequestUri + "/" + participant.Id), participantsDto);
        }
    }
}
