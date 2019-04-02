using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BrightIdeas.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

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

        [HttpGet("brightideas")]
        public IActionResult ShowIdeas()
        {
            int? GetIdInSession = HttpContext.Session.GetInt32("UserId");
            if(GetIdInSession == null)
            {
                return RedirectToAction("ShowLogin", "Login");
            }
            else
            {
                BrightIdeaVM Idea = new BrightIdeaVM()
                {
                    ThisUser = dbContext.Users.FirstOrDefault(u => u.UserId == GetIdInSession),
                    AllIdeas = dbContext.BrightIdeas
                    .Include(l => l.Likes)
                    .ThenInclude(u => u.Liker)
                    .OrderByDescending(c => c.CreatedAt)
                    .ToList()
                };
                return View("Ideas", Idea);
            }
        }

        [HttpPost("brightideas/create")]
        public IActionResult CreateIdea(BrightIdea NewIdea)
        {
            if(ModelState.IsValid)
            {
                dbContext.Add(NewIdea);
                dbContext.SaveChanges();
                return RedirectToAction("ShowIdeas");
            }
            else
            {
                int? GetIdInSession = HttpContext.Session.GetInt32("UserId");
                BrightIdeaVM GetUser = new BrightIdeaVM()
                {
                    ThisUser = dbContext.Users.FirstOrDefault(u => u.UserId == GetIdInSession),
                    AllIdeas = dbContext.BrightIdeas
                    .Include(l => l.Likes)
                    .ThenInclude(u => u.Liker)
                    .OrderByDescending(c => c.CreatedAt)
                    .ToList()
                };
                return View("Ideas", GetUser);
            }
        }

        [HttpGet("brightideas/{id}/{uid}")]
        public IActionResult ViewIdea(int id, int uid)
        {
            BrightIdeaVM Idea = new BrightIdeaVM()
            {
                GetIdea = dbContext.BrightIdeas
                .Include(l => l.Likes)
                .ThenInclude(u => u.Liker)
                .FirstOrDefault(i => i.IdeaId == id),

                ThisUser = dbContext.Users.FirstOrDefault(u => u.UserId == uid)
            };
            return View("ViewIdea", Idea);
        }

        [HttpGet("brightideas/users/{id}")]
        public IActionResult ViewUser(int id)
        {
            BrightIdeaVM GetUser = new BrightIdeaVM()
            {
                ThisUser = dbContext.Users.FirstOrDefault(u => u.UserId == id)
            };
            return View("ViewUser", GetUser);
        }

        [HttpGet("brightideas/like/{iid}/{uid}")]
        public IActionResult LikeIdea(int iid, int uid)
        {
            Like NewLike = new Like();
            NewLike.IdeaId = iid;
            NewLike.UserId = uid;
            dbContext.Add(NewLike);
            dbContext.SaveChanges();
            return RedirectToAction ("ShowIdeas");
        }

        [HttpGet("brightideas/delete/{id}")]
        public IActionResult DeleteIdea(int id)
        {
            BrightIdea GetIdea = dbContext.BrightIdeas.FirstOrDefault(i => i.IdeaId == id);
            dbContext.Remove(GetIdea);
            dbContext.SaveChanges();
            return RedirectToAction("ShowIdeas");
        }
    }
}