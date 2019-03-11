using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ViewModelFun.Models;


namespace ViewModelFun.Controllers
{
    public class HomeController : Controller
    {
        [Route("")]
        [HttpGet]
        public IActionResult Index()
        {
            string MyMessage = "Just messing around with some view models!";
            return View("Index", MyMessage);
        }

        [HttpGet("numbers")]
        public IActionResult Numbers()
        {
            int[] MyNumbers = new int[]
            {
                1,2,3,4,5,6,7,8,9,10
            };
            return View(MyNumbers);
        }

        [HttpGet("users")]
        public IActionResult Users()
        {
            User User1 = new User()
            {
                FirstName = "Michael",
                LastName = "Shea"
            };
            User User2 = new User()
            {
                FirstName = "Russell",
                LastName = "Westbrook"
            };

            List<User> viewModel = new List<User>()
            {
                User1, User2
            };
            return View(viewModel);
        }

        [HttpGet("user")]
        public IActionResult SingleUser()
        {
            User Me = new User()
            {
                FirstName = "Michael",
                LastName = "Shea"
            };
            return View(Me);
        }

    }

}
