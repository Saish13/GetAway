using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GetAway.Models
{
    public class Feedback
    {
        [Required]
        public int Id { get; set; }

        public int UserID { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }

        [Required]
        [StringLength(255)]
        [Display(Name = "Message")]
        public string FeedbackMesaage { get; set; }

        public DateTime FeedbackDateTime { get; set; }

        [StringLength(50)]
        [Display(Name = "Subject")]
        public string FeedbackSubject { get; set; }

    }

}