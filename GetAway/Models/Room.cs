using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GetAway.Models
{
    public class Room
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public byte RoomNumber { get; set; }

        [StringLength(30)]
        public string RoomType { get; set; }

        [StringLength(255)]
        [Display(Name = "Room Picture 1")]
        public string RoomPicture1 { get; set; }

        [StringLength(255)]
        [Display(Name = "Room Picture 2")]
        public string RoomPicture2 { get; set; }

        [StringLength(255)]
        [Display(Name = "Room Picture 3")]
        public string RoomPicture3 { get; set; }

        [Display(Name = "Room Description")]
        public string RoomDescription { get; set; }

        [Display(Name = "Room Status")]
        public byte RoomStatus { get; set; }

        [ForeignKey("HotelID")]
        public Hotel Hotel { get; set; }

        [Required]
        [Display(Name = "Hotel Name")]
        public int HotelID { get; set; }

        [Required]
        [Display(Name = "Rate")]
        public int RoomRate { get; set; }
    }
}