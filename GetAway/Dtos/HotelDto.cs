using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GetAway.Dtos
{
    public class HotelDto
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string HotelName { get; set; }

        public string HotelAddress { get; set; }

        [StringLength(255)]
        public string HotelContactNumber { get; set; }

        [StringLength(255)]
        public string HotelPicture1 { get; set; }

        [StringLength(255)]
        public string HotelPicture2 { get; set; }

        [StringLength(255)]
        public string HotelPicture3 { get; set; }

        [StringLength(255)]
        public string HotelPicture4 { get; set; }

        [StringLength(255)]
        public string HotelPicture5 { get; set; }

        [StringLength(255)]
        public string HotelPicture6 { get; set; }

        public byte HotelRooms { get; set; }

        public string HotelDescription { get; set; }

        public byte HotelRating { get; set; }
    }
}