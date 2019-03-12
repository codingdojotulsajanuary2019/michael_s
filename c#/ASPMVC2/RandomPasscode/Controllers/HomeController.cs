using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RandomPasscode.Models;
using Microsoft.AspNetCore.Http;

namespace RandomPasscode.Controllers
{
    public class HomeController : Controller
    {
        [Route("")]
        [HttpGet]
        public IActionResult Index()
        {
            if(HttpContext.Session.GetInt32("count")== null)
            {
                HttpContext.Session.SetInt32("count", 0);
            }
            else
            {
                int? CodeCount = HttpContext.Session.GetInt32("count");
                HttpContext.Session.SetInt32("count", (int)++CodeCount);
            }
            Code MyCode = new Code();
            string Chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            Random rand = new Random();
            for(int i = 0; i < 14 ; i++)
            {
                var AlphaNum = Chars[rand.Next(Chars.Length)];
                MyCode.RandomCode[i] = AlphaNum.ToString();
            }
            ViewBag.count = HttpContext.Session.GetInt32("count");
            
            return View("Index", MyCode);
        }

    }
}
