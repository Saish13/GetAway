using GetAway.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GetAway.ViewModels
{
    public class AddRoomViewModel
    {
        public IEnumerable<Hotel> Hotel { get; set; }
        public Room Room { get; set; }
    }
}