using System;
using System.ComponentModel.DataAnnotations;

namespace BrightIdeas.Models
{
    public class LoginViewModel
    {
        public User User {get;set;}
        public LoginUser LoginUser {get; set;}
    }
}