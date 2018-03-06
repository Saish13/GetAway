using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GetAway.Models
{
    public class Hotel
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        [Display(Name = "Hotel Name")]
        public string HotelName { get; set; }

        [Display(Name = "Hotel Address")]
        public string HotelAddress { get; set; }

        [Display(Name = "Contact Number")]
        [StringLength(255)]
        public string HotelContactNumber { get; set; }

        [StringLength(255)]
        [Display(Name = "Hotel Picture 1")]
        public string HotelPicture1 { get; set; }

        [StringLength(255)]
        [Display(Name = "Hotel Picture 2")]
        public string HotelPicture2 { get; set; }

        [StringLength(255)]
        [Display(Name = "Hotel Picture 3")]
        public string HotelPicture3 { get; set; }

        [StringLength(255)]
        [Display(Name = "Hotel Picture 4")]
        public string HotelPicture4 { get; set; }

        [StringLength(255)]
        [Display(Name = "Hotel Picture 5")]
        public string HotelPicture5 { get; set; }

        [StringLength(255)]
        [Display(Name = "Hotel Picture 6")]
        public string HotelPicture6 { get; set; }

        [Display(Name = "Rooms Available")]
        public byte HotelRooms { get; set; }

        [Display(Name = "Description")]
        public string HotelDescription { get; set; }

        [Display(Name = "Hotel Rating")]
        public byte HotelRating { get; set; }
    }
}