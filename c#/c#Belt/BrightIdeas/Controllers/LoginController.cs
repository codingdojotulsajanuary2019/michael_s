using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BrightIdeas.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;
using System.Text.RegularExpressions;

namespace BrightIdeas.Controllers
{
    public class LoginController : Controller
    {
        private MyContext dbContext;
     
        // here we can "inject" our context service into the constructor
        public LoginController(MyContext context)
        {
            dbContext = context;
        }
        
        [HttpGet("")]
        public IActionResult ShowLogin()
        {
            return View("Login");
        }

        [HttpPost("register")]
        public IActionResult RegisterUser(User User)
        {
            if(ModelState.IsValid)
                {
                    if(dbContext.Users.Any(u => u.Email == User.Email))
                    {
                        ModelState.AddModelError("User.Email", "Email already taken");
                        return View("Login");
                    }

                    else
                    {
                        PasswordHasher<User> Hasher = new PasswordHasher<User>();
                        User.Password = Hasher.HashPassword(User, User.Password);
                        dbContext.Add(User);
                        dbContext.SaveChanges();

                        User ThisUser = dbContext.Users.LastOrDefault();
                        HttpContext.Session.SetInt32("UserId", ThisUser.UserId);
                        HttpContext.Session.SetString("Name", ThisUser.Name);

                        return RedirectToAction("ShowIdeas", "BrightIdeas");
                    }
                }
            else
                {
                    return View("Login");
                }
        }

        [HttpPost("login")]
        public IActionResult Login(LoginUser LoginUser)
        {
            if(ModelState.IsValid)
                {
                    var userindb = dbContext.Users.FirstOrDefault(u => u.Email == LoginUser.Email);
                    if(userindb == null)
                    {
                        ModelState.AddModelError("LoginUser.Email", "Invalid Email/Password");
                        ModelState.AddModelError("LoginUser.Password", "Invalid Email/Password");
                        return View("Login");
                    }
                    var hasher = new PasswordHasher<LoginUser>();
                    var result = hasher.VerifyHashedPassword(LoginUser, userindb.Password, LoginUser.Password);

                    if(result ==0)
                    {
                        ModelState.AddModelError("LoginUser.Email", "Incorrect Email/Password ");
                        return View("Login");

                    }
                    else
                    {
                        int GetUserId = userindb.UserId;
                        string GetUserName = userindb.Name;
                        HttpContext.Session.SetInt32("UserId", GetUserId);
                        HttpContext.Session.SetString("Name", GetUserName);
                        return RedirectToAction("ShowIdeas", "BrightIdeas");
                    }
                }
            else
            {
                return View("Login");
            }
        }

        [HttpGet("logout")]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("ShowLogin");
        }

    }


}

