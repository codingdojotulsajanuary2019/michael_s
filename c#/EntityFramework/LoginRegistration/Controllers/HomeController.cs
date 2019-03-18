using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LoginRegistration.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace LoginRegistration.Controllers
{

    public class HomeController : Controller
    {
        private MyContext dbContext;
        public HomeController(MyContext context)
        {
            dbContext = context;
        }
        
        [HttpGet("")]
        public IActionResult Index()
        {
            return View("Register");
        }
        [HttpPost("register")]
        public IActionResult Register(User input)
        {
            if(ModelState.IsValid)
            {
                if(dbContext.Users.Any(u => u.Email == input.Email))
                {
                    ModelState.AddModelError("Email", "Email already taken");
                    return View("Register");
                }
                else
                {
                    PasswordHasher<User> Hasher = new PasswordHasher<User>();
                    input.Password = Hasher.HashPassword(input, input.Password);
                    dbContext.Add(input);
                    dbContext.SaveChanges();

                    return Redirect("Success");
                }
            }
            else
            {
                return View("Register");
            }
        }

        [HttpGet("login")]
        public IActionResult Login(User input)
        {
            if(ModelState.IsValid)
            {
                var userindb = dbContext.Users.FirstOrDefault(u => u.Email == input.Email);
                if(userindb == null)
                {
                    ModelState.AddModelError("Email", "Invalid Email/Password");
                    return View("Login");
                }
                var hasher = new PasswordHasher<User>();
                var result = hasher.VerifyHashedPassword(input, userindb.Password, input.Password);

                if(result ==0)
                {
                    ModelState.AddModelError("Email", "Email/Password does not exist");
                    return View("Login");

                }
                return View("Success");
            }
            return View("Login");
        }

        [HttpGet("Success")]
        public IActionResult Success()
        {

            return View("Success");
        }

    }
}
