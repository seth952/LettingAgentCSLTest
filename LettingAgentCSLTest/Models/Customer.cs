using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LettingAgentCSLTest.Models
{
    public class Customer
    {
        [Display(Name = "First Name")]
        [Required(ErrorMessage ="Please enter your first name")]
        public string FirstName { get; set; }
        
        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Please enter your last name")]
        public string LasttName { get; set; }
        
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email Address")]
        [Required(ErrorMessage = "Please enter your email address")]
        public string EmailAddress { get; set; }

        [Display(Name = "Confirm Email")]
        [Compare("EmailAddress", ErrorMessage = "The email and confirm email must match")]
        public string ConfirmEmail { get; set; }
        
        [Display(Name = "Password")]

        [DataType(DataType.Password)]
        [StringLength(100, MinimumLength = 10,ErrorMessage ="Your password must be at least 10 characters")]
        public string Password { get; set; }
        
        [Display(Name = "Confirm Password")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "The password and confirm password must match")]
        public string ConfirmPassword { get; set; }






    }
}