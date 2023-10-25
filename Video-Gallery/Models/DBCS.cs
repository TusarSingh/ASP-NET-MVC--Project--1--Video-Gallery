using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;



namespace Vidly.Models
{
    public class DBCS : IdentityDbContext//<ApplicationUser>
    {
        public DBCS()
        {

        }

        public DbSet<ApplicationUser> AspNetUser { get; set; }


    }

}