﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VidlyMovieMVC.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        public bool IsSubscribedToNewsletter { get; set; }
        public DateTime? Birthdate { get; set; }

        //relationship with membershipTypes

        public MembershipType MembershipType { get; set; }
        //foreign key
        public byte MembershipTypeId { get; set; }

    }
}