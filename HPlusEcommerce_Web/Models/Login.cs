using HPlusEcommerce_Web.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HPlusEcommerce_Web.Models
{
    public class Login
    {
        [Required]
        [EmailAddress(ErrorMessage = "Enter a valid email address"]
        public string Username { get; set; }

        [Required]
        [MinLength(8, ErrorMessage = "Password must be at least 8 characters long")]
        [CommonPasswords(ErrorMessage = "This password is too common.")]
        public string Password { get; set; }
    }
}