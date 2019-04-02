using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace BrightIdeas.Models
{
    public class User
    {
        [Key]
        public int UserId {get; set;}

        [Display(Name="First Name")]
        [Required(ErrorMessage="Name cannot be empty")]
        [MinLength(2, ErrorMessage="Name must be longer than 2 characters")]
        [RegularExpression("^[a-zA-Z ]*$", ErrorMessage="Name can only container letters")]
        public string Name {get; set;}

        [Display(Name="Alias")]
        [Required(ErrorMessage="Alias cannot be empty")]
        [MinLength(2, ErrorMessage="Alias must be longer than 2 characters")]
        [RegularExpression("^[a-zA-Z0-9]+$", ErrorMessage="Alias can only container letters & Numbers")]
        public string Alias {get;set;}


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

        public List<BrightIdea> UserIdeas {get; set;}
        public List<Like> LikedIdeas {get; set;}


       
    }
}