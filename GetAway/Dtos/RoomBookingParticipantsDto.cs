using GetAway.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GetAway.Dtos
{
    public class RoomBookingParticipantsDto
    {
        [Required]
        public int Id { get; set; }

        public string ParticipantName { get; set; }

        public int ParticipantAge { get; set; }

        [ForeignKey("RoomBookingId")]
        public RoomBooking RoomBooking { get; set; }

        public int RoomBookingId { get; set; }
    }
}