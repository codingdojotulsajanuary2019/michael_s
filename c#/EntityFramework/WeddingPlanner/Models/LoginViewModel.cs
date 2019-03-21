using System;
using WeddingPlanner.Models;
using System.ComponentModel.DataAnnotations;

namespace WeddingPlanner.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Email cannot be empty")]
        public User User {get; set;}


        [Required(ErrorMessage = "Password cannot be empty")]
        public LoginUser LoginUser {get; set;}
    }
}