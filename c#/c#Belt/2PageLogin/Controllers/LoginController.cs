﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TwoPageLogin.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;

namespace TwoPageLogin.Controllers
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
        public IActionResult ShowRegister()
        {
            return View("Register");
        }

        [HttpPost("register")]
        public IActionResult RegisterUser(User User)
        {
            if(ModelState.IsValid)
                {
                    if(dbContext.Users.Any(u => u.Email == User.Email))
                    {
                        ModelState.AddModelError("User.Email", "Email already taken");
                        return View("Register");
                    }

                    else
                    {
                        PasswordHasher<User> Hasher = new PasswordHasher<User>();
                        User.Password = Hasher.HashPassword(User, User.Password);
                        dbContext.Add(User);
                        dbContext.SaveChanges();

                        User ThisUser = dbContext.Users.Last();
                        HttpContext.Session.SetInt32("UserId", ThisUser.UserId);

                        return RedirectToAction("Success", "Success");
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
                        string GetUserFirstName = userindb.FirstName;
                        HttpContext.Session.SetInt32("UserId", GetUserId);
                        HttpContext.Session.SetString("FirstName", GetUserFirstName);
                        return RedirectToAction("Success", "Success");
                    }
                }
            else
            {
                return View("Login");
            }
        }

    }
}
