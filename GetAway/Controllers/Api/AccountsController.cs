using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Microsoft.AspNet.Identity;
using GetAway.Models;
using System.Web;
using Microsoft.AspNet.Identity.Owin;

namespace GetAway.Controllers.Api
{
    public class AccountsController : ApiController
    {
        protected ApplicationDbContext ApplicationDbContext { get; set; }
        protected UserManager<ApplicationUser> UserManager { get; set; }

        public AccountsController()
        {
            var _context = new ApplicationDbContext();
        }


    }
}
