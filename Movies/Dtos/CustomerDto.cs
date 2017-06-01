using Movies.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Movies.Dtos
{
    public class CustomerDto
    {

        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter customers name")]
        [StringLength(55)]
        public string Name { get; set; }

        //[Min18YearsIfAMember]
        public DateTime? Birthday { get; set; }
        public bool IsSubscribedToNewsletter { get; set; }

        public byte MembershipTypeId { get; set; }
    }
}