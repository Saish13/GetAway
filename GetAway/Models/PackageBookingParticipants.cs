using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GetAway.Models
{
    public class PackageBookingParticipants
    {
        [Required]
        public int Id { get; set; }

        public string ParticipantName { get; set; }

        public int ParticipantAge { get; set; }

        [ForeignKey("PackageBookingId")]
        public PackageBooking PackageBooking { get; set; }

        public int PackageBookingId { get; set; }
    }
}