using GetAway.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GetAway.ViewModels
{
    public class HotelBookingDetailsViewModel
    {
        public Hotel Hotel { get; set; }
        public ApplicationUser User { get; set; }
    }
}