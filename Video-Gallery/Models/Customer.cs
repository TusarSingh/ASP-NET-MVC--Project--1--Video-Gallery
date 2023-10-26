 using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Customer
    {
        public int ID { get; set; }

        [Required(ErrorMessage ="Please Enter Customer Name")]
        [StringLength(255)]
        public string Name { get; set; }

        public bool IsSubscribedToNewsletter { get; set; }

        [Min18YearsIfAMember]
        public MembershipType MembershipType { get; set; }

        [Display(Name = "MemberShip Type")]
        public byte MembershipTypeId { get; set; }

        [Display(Name = "Date Of Birth")]
        [Min18YearsIfAMember]
        [Required(ErrorMessage ="Please Enter Birth Date")]
        public DateTime? BirthOfDate { get; set; }


    }
}










