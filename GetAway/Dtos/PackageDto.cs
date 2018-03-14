using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GetAway.Dtos
{
    public class PackageDto
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string PackageName { get; set; }

        [StringLength(255)]
        public string PackagePicture1 { get; set; }

        [StringLength(255)]
        public string PackagePicture2 { get; set; }

        [StringLength(255)]
        public string PackagePicture3 { get; set; }

        [StringLength(255)]
        public string PackagePicture4 { get; set; }

        [StringLength(255)]
        public string PackagePicture5 { get; set; }


        [StringLength(255)]
        public string PackagePicture6 { get; set; }

        [StringLength(255)]
        public string PackageType { get; set; }

        public string PackageDescription { get; set; }

        public string PackageActivities { get; set; }

        public byte PackageDuration { get; set; }

        public int Rate { get; set; }

        public byte Discount { get; set; }
    }
}