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
    public class PackageBookingParticipantsController : ApiController
    {
        private ApplicationDbContext _context;
        public PackageBookingParticipantsController()
        {
            _context = new ApplicationDbContext();
        }

        // GET /api/....
        public IHttpActionResult GetParticipants(int id)
        {
            var packageParticipant = _context.PackageBookingParticipants.ToList().Where(pbp => pbp.PackageBookingId == id).Select(Mapper.Map<PackageBookingParticipants,PackageBookingParticipantsDto>);
            return Ok(packageParticipant);
        }

        [HttpPost]
        public IHttpActionResult CreateParticipants(PackageBookingParticipantsDto participantsDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var participant = Mapper.Map<PackageBookingParticipantsDto, PackageBookingParticipants>(participantsDto);
            _context.PackageBookingParticipants.Add(participant);
            _context.SaveChanges();

            participantsDto.Id = participant.Id;
            return Created(new Uri(Request.RequestUri+"/"+participant.Id),participantsDto);
        }

    }
}
