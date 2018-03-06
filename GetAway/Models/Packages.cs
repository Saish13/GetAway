using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GetAway.Models
{
    public class Packages
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        [Display(Name = "Package Name")]
        public string PackageName { get; set; }

        [StringLength(255)]
        [Display(Name = "Package Picture 1")]
        public string PackagePicture1 { get; set; }

        [StringLength(255)]
        [Display(Name = "Package Picture 2")]
        public string PackagePicture2 { get; set; }

        [StringLength(255)]
        [Display(Name = "Package Picture 3")]
        public string PackagePicture3 { get; set; }

        [StringLength(255)]
        [Display(Name = "Package Picture 4")]
        public string PackagePicture4 { get; set; }

        [StringLength(255)]
        [Display(Name = "Package Picture 5")]
        public string PackagePicture5 { get; set; }

        
        [StringLength(255)]
        [Display(Name = "Package Picture 6")]
        public string PackagePicture6 { get; set; }

        [StringLength(255)]
        [Display(Name = "Package Type")]
        public string PackageType { get; set; }

        [Display(Name = "Package Description")]
        public string PackageDescription { get; set; }

        [Display(Name = "Package Activities")]
        public string PackageActivities { get; set; }

        [Display(Name = "Package Duration (Hours)")]
        public byte PackageDuration { get; set; }

        [Display(Name = "Package Rate")]
        public int Rate { get; set; }

        [Display(Name = "Package Discount")]
        public byte Discount { get; set; }
    }
}