using System;
using System.ComponentModel.DataAnnotations;

namespace TheWall.Models
{
    public class LoginViewModel
    {
        public User User {get;set;}
        public LoginUser LoginUser {get; set;}
    }
}