using System;
using System.ComponentModel.DataAnnotations;

namespace SinglePageLogin.Models
{
    public class LoginUser
    {
        [Required(ErrorMessage="Email Field Required")]
        public string Email {get; set;}

        [Required(ErrorMessage="Password Field Required")]
        public string Password {get; set;}

    }
}