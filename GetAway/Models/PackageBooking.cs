using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GetAway.Models
{
    public class PackageBooking
    {
        [Required]
        public int Id { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        public DateTime BookingDate { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        public DateTime PackageStartDate { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        public DateTime PackageEndDate { get; set; }

        public byte BookingStatus { get; set; }

        public byte PaymentStatus { get; set; }

        public string AdditionaInfo { get; set; }

        public int PaidAmount { get; set; }

        public byte DiscountReceived { get; set; }

        [ForeignKey("PackageId")]
        public Package Package { get; set; }

        public int PackageId { get; set; }

        [StringLength(128)]
        public string UserID { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }
    }
}