using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GetAway.Models
{
    public class RoomBooking
    {
        [Required]
        public int Id { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        public DateTime BookingDate { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        public DateTime RoomStartDate { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        public DateTime RoomEndDate { get; set; }

        public byte BookingStatus { get; set; }

        public byte PaymentStatus { get; set; }

        public string AdditionaInfo { get; set; }

        public int PaidAmount { get; set; }

        public byte DiscountReceived { get; set; }

        [ForeignKey("RoomId")]
        public Room Room { get; set; }

        public int RoomId { get; set; }

        [StringLength(128)]
        public string UserID { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }
    }
}