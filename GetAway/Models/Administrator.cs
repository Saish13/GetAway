using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GetAway.Models
{
    public class Administrator
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Username")]
        [StringLength(255)]
        public string AdministratorName { get; set; }

        [Required]
        [Display(Name = "Password")]
        [StringLength(32)]
        public string Password { get; set; }
    }
}