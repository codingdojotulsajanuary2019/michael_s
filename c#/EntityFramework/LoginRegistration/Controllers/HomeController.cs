using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LoginRegistration.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;

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
        public IActionResult Register(User user)
        {
            if(ModelState.IsValid)
            {
                if(dbContext.Users.Any(u => u.Email == user.Email))
                {
                    ModelState.AddModelError("Email", "Email already taken");
                    return View("Register");
                }
                else
                {
                    PasswordHasher<User> Hasher = new PasswordHasher<User>();
                    user.Password = Hasher.HashPassword(user, user.Password);
                    dbContext.Add(user);
                    dbContext.SaveChanges();

                    return RedirectToAction("Success");
                }
            }
            else
            {
                return View("Register");
            }
        }

        [HttpGet("login")]
        public IActionResult ShowLogin()
        {
            return View("Login");
        }

        [HttpPost("login/submit")]
        public IActionResult Login(LoginUser input)
        {
            if(ModelState.IsValid)
            {
                var userindb = dbContext.Users.FirstOrDefault(u => u.Email == input.Email);
                if(userindb == null)
                {
                    ModelState.AddModelError("Email", "Invalid Email/Password");
                    return View("Login");
                }
                var hasher = new PasswordHasher<LoginUser>();
                var result = hasher.VerifyHashedPassword(input, userindb.Password, input.Password);

                if(result ==0)
                {
                    ModelState.AddModelError("Email", "Incorrect Email/Password ");
                    return View("Login");

                }
                else
                {
                    int GetUserId = userindb.UserId;
                    string GetUserFirstName = userindb.FirstName;
                    HttpContext.Session.SetInt32("UserId", GetUserId);
                    HttpContext.Session.SetString("FirstName", GetUserFirstName);
                    return RedirectToAction("Success");
                }
            }
            else
            {
                return View("Login");
            }
        }

        [HttpGet("success")]
        public IActionResult Success()
        {
            int? IsIdInSession = HttpContext.Session.GetInt32("UserId");
            if(IsIdInSession == null)
            {
                return RedirectToAction("ShowLogin");
            }
            else 
            {
                string UserFirstName = HttpContext.Session.GetString("FirstName");
                ViewBag.FirstName = UserFirstName;
                return View("Success");
            }

        }

    }
}
