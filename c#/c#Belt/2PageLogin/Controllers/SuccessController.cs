using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TwoPageLogin.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;

namespace SinglePageLogin.Controllers
{
    public class SuccessController : Controller
    {
        [HttpGet("success")]
        public IActionResult Success()
        {
            int? IsIdInSession = HttpContext.Session.GetInt32("UserId");
            if(IsIdInSession == null)
            {
                return RedirectToAction("ShowLogin", "Login");
            }
            return View("Success");
        }
    }
}