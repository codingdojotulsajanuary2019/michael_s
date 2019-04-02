using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TheWall.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;

namespace TheWall.Controllers
{
    public class WallController : Controller
    {
        private MyContext dbContext;
     
        // here we can "inject" our context service into the constructor
        public WallController(MyContext context)
        {
            dbContext = context;
        }

        [HttpGet("wall")]
        public IActionResult ShowWall()
        {
            int? GetUserId = HttpContext.Session.GetInt32("UserId");
            if(GetUserId == null)
            {
                return RedirectToAction("ShowLogin", "Login");
            }
            else
            {

                string FirstName = HttpContext.Session.GetString("FirstName");
                ViewBag.UserId = GetUserId;
                ViewBag.FirstName = FirstName;

                return View("Wall");
            }
        }

        [HttpPost("wall/post")]
        public IActionResult MakePost(Message NewMessage)
        {
            if(ModelState.IsValid)
            {
                dbContext.Add(NewMessage);
                dbContext.SaveChanges();
                Console.WriteLine("!!!!!!!!!!!!!!!!");
                return RedirectToAction("ShowWall");
            }
            else
            {
                ModelState.AddModelError("NewMessage.UserMessage", "Post Cannot Be Blank");
                Console.WriteLine("&&&&&&&&&&&&&&&&&&&&&&&&&&&&&");
                int? GetUserId = HttpContext.Session.GetInt32("UserId");
                string FirstName = HttpContext.Session.GetString("FirstName");
                ViewBag.UserId = GetUserId;
                ViewBag.FirstName = FirstName;
                return View("Wall");
            }
        }
    }
}