using System;
using System.ComponentModel.DataAnnotations;

namespace SinglePageLogin.Models
{
    public class LoginViewModel
    {
        public User User {get;set;}
        public LoginUser LoginUser {get; set;}
    }
}