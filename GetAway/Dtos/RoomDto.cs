using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GetAway.Dtos
{
    public class RoomDto
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public byte RoomNumber { get; set; }

        [StringLength(30)]
        public string RoomType { get; set; }

        [StringLength(255)]
        public string RoomPicture1 { get; set; }

        [StringLength(255)]
        public string RoomPicture2 { get; set; }

        [StringLength(255)]
        public string RoomPicture3 { get; set; }

        public string RoomDescription { get; set; }

        public byte RoomStatus { get; set; }

        [ForeignKey("HotelID")]
        public HotelDto Hotel { get; set; }

        [Required]
        public int HotelID { get; set; }

        [Required]
        public int RoomRate { get; set; }
    }
}