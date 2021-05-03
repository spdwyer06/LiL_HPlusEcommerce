﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HPlusEcommerce_Web.Data.Entities
{
    public partial class User
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(100)]
        public string LastName { get; set; }

        [Required]
        [StringLength(200)]
        public string EmailAddress { get; set; }

        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }
    }
}