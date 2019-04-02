using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BrightIdeas.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;

namespace BrightIdeas.Controllers
{
    public class BrightIdeasController : Controller
    {
        private MyContext dbContext;
     
        // here we can "inject" our context service into the constructor
        public BrightIdeasController(MyContext context)
        {
            dbContext = context;
        }

        [HttpGet("ideas")]
        public IActionResult ShowIdeas()
        {
            int? GetIdInSession = HttpContext.Session.GetInt32("UserId");
            if(GetIdInSession == null)
            {
                return RedirectToAction("ShowLogin", "Login");
            }
            else
            {
                string GetUserName = HttpContext.Session.GetString("Name");
                ViewBag.Name = GetUserName;
                ViewBag.UserId = GetIdInSession;
                return View("Ideas");
            }
        }
    }
}