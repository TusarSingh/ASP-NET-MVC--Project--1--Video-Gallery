using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

//using Microsoft.SqlServer;
//using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Vidly.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }


    }
}