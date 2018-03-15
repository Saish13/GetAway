using GetAway.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GetAway.Dtos
{
    public class FeedbackDto
    {
        [Required]
        public int Id { get; set; }

        public int UserID { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }

        [Required]
        [StringLength(255)]
        public string FeedbackMesaage { get; set; }

        public DateTime FeedbackDateTime { get; set; }

        [StringLength(50)]
        public string FeedbackSubject { get; set; }
    }
}