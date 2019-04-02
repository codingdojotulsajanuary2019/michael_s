using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace SinglePageLogin.Models
{
    public class User
    {
        [Key]
        public int UserId {get; set;}

        [Display(Name="First Name")]
        [Required(ErrorMessage="First Name cannot be empty")]
        [MinLength(2, ErrorMessage="First Name must be longer than 2 characters")]
        public string FirstName {get; set;}

        [Display(Name="Last Name")]
        [Required(ErrorMessage="Last Name cannot be empty")]
        [MinLength(2, ErrorMessage="Last Name must be longer than 2 characters")]
        public string LastName {get;set;}


        [Display(Name="Email Address")]
        [Required(ErrorMessage="Email cannot be empty")]
        [EmailAddress]
        public string Email {get; set;}


        [Display(Name="Password")]
        [Required(ErrorMessage="Password cannot be empty")]
        [MinLength(8, ErrorMessage="Password must be 8 Characters or Longer!")]
        public string Password {get; set;}

        [NotMapped]
        [Display(Name="Confirm Password")]
        [Compare("Password", ErrorMessage="Passwords do not Match")]
        [MinLength(8, ErrorMessage="Password must be 8 Characters or Longer")]
        [Required(ErrorMessage="Password cannot be empty")]
        [DataType(DataType.Password)]
        public string PWConfirm {get; set;}
        public DateTime CreatedAt {get; set;} = DateTime.Now;
        public DateTime UpdatedAt {get; set;} = DateTime.Now;

       
    }
}