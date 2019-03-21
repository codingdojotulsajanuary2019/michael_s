using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WeddingPlanner.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;

namespace WeddingPlanner.Controllers
{
    public class WeddingPlannerController : Controller
    {
        private MyContext dbContext;
     
        // here we can "inject" our context service into the constructor
        public WeddingPlannerController(MyContext context)
        {
            dbContext = context;
        }
        [HttpGet("dashboard")]
        public IActionResult ShowDashboard()
        {
            int? IsIdInSession = HttpContext.Session.GetInt32("UserId");
            if(IsIdInSession == null)
            {
                return RedirectToAction("ShowLogin", "Home");
            }
            else 
            {
                string UserFirstName = HttpContext.Session.GetString("FirstName");
                ViewBag.FirstName = UserFirstName;
                ViewBag.UserId = IsIdInSession;
                WeddingViewModel Dashboard = new WeddingViewModel()
                {
                    AllWeddings = dbContext.Weddings
                    .Include(w => w.Guests)
                    .ThenInclude(u =>u.Guest)
                    .ToList()
                };
                return View("Dashboard", Dashboard);
            }
        }

        [HttpGet("wedding/new")]
        public IActionResult ShowNewWedding()
        {
            ViewBag.UserId = HttpContext.Session.GetInt32("UserId");
            return View("NewWedding");
        }
        
        [HttpPost("wedding/new/create")]
        public IActionResult CreateNewWedding(Wedding NewWedding)
        {
            
            dbContext.Add(NewWedding);
            dbContext.SaveChanges();
            return RedirectToAction("ShowDashboard");
        }

        [HttpGet("wedding/view/{id}")]
        public IActionResult ViewWedding(int id)
        {
            WeddingViewModel ViewWedding = new WeddingViewModel()
            {
                ThisWedding = dbContext.Weddings
                .Include(wed => wed.Guests)
                .ThenInclude(g => g.Guest)
                .FirstOrDefault(w => w.WeddingId == id)
                
            };
            string UserFirstName = HttpContext.Session.GetString("FirstName");
            ViewBag.FirstName = UserFirstName;
            return View("ViewWedding", ViewWedding);
        }

        [HttpPost("wedding/rsvp")]
        public IActionResult RsvpToWedding(Reservation NewRSVP)
        {
            dbContext.Add(NewRSVP);
            dbContext.SaveChanges();

            return RedirectToAction("ShowDashboard");
        }

        [HttpGet("wedding/unrsvp/{id}")]
        public IActionResult RemoveRSVP(int id)
        {
            int? userId = HttpContext.Session.GetInt32("UserId");
            Reservation Remove = dbContext.Reservations
            .Where(u => u.UserId ==  (int)userId)
            .FirstOrDefault(w => w.WeddingId == id);

            dbContext.Remove(Remove);
            dbContext.SaveChanges();

            return RedirectToAction("ShowDashboard");
        }

        [HttpPost("wedding/delete")]
        public IActionResult DeleteWedding(Wedding ThisWedding)
        {
            dbContext.Remove(ThisWedding);
            dbContext.SaveChanges();
            return RedirectToAction("ShowDashboard");
        }
    }
}