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
    public class FeedbacksController : ApiController
    {
        private ApplicationDbContext _context;

        public FeedbacksController()
        {
            _context = new ApplicationDbContext();
        }

        // GET /api/feedbacks/
        public IHttpActionResult GetFeedback()
        {
            var feedbackDto = _context.Feedback.ToList().Select(Mapper.Map<Feedback, FeedbackDto>);
            return Ok(feedbackDto);
        }

        // GET /api/feedbacks/1
        public IHttpActionResult GetFeedback(int id)
        {
            var feedback = _context.Feedback.SingleOrDefault(f => f.Id == id);

            if (feedback == null)
                return NotFound();

            return Ok(Mapper.Map<Feedback, FeedbackDto>(feedback));
        }

        // POST /api/feedback
        [HttpPost]
        public IHttpActionResult CreateFeedback(FeedbackDto feedbackDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var feedback = Mapper.Map<FeedbackDto, Feedback>(feedbackDto);
            _context.Feedback.Add(feedback);
            _context.SaveChanges();

            feedbackDto.Id = feedback.Id;
            return Created(new Uri(Request.RequestUri + "/" + feedback.Id), feedbackDto);

        }

        // DELETE /api/feedbacks/1
        [HttpDelete]
        public IHttpActionResult DeleteFeedback(int id)
        {
            var feedbackInDb = _context.Feedback.SingleOrDefault(f => f.Id == id);

            if (feedbackInDb == null)
                return NotFound();

            _context.Feedback.Remove(feedbackInDb);
            _context.SaveChanges();

            return Ok();
        }
    }
}
