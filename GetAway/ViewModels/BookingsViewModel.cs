using GetAway.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GetAway.ViewModels
{
    public class AdminPackageBookingViewModel
    {
        public PackageBooking PackageBooking { get; set; }

        public PackageBookingParticipants PackageBookingParticipants { get; set; }

        public ApplicationUser User { get; set; }

        public Package Package { get; set; }
    }

    public class AdminRoomBookingViewModel
    {
        public RoomBooking RoomBooking { get; set; }

        public RoomBookingParticipants RoomBookingParticipants { get; set; }

        public ApplicationUser User { get; set; }

        public Room Room { get; set; }
    }


}