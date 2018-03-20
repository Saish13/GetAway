using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GetAway.Models;

namespace GetAway.ViewModels
{
    public class BookingDetailsViewModel
    {
        public Package Package { get; set; }
        public ApplicationUser User { get; set; }
    }
}