using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ChefsDishes.Models;
using Microsoft.EntityFrameworkCore;


namespace ChefsDishes.Controllers
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
            ViewModel AllChefs = new ViewModel ()
            {
                AllChefs = dbContext.Chef.Include(c => c.ChefsDishes).ToList()

            };

            return View("Chefs", AllChefs);
        }

        [HttpGet("dishes")]
        public IActionResult ShowDishes()
        {
            ViewModel AllDishes = new ViewModel()
            {
                AllDishes = dbContext.Dish.Include(u => u.Creator).ToList()
            };
            return View("Dishes", AllDishes);
        }
        
        [HttpGet("chefs/new")]
        public IActionResult ShowNewChef()
        {
            return View("NewChef");
        }
        [HttpPost("chefs/add")]
        public IActionResult AddChef(Chef Input)
        {
            if(ModelState.IsValid)
            {
                dbContext.Add(Input);
                dbContext.SaveChanges();
                return Redirect("/");
            }
            else
            {
                return View("NewChef");
            }
        }

        [HttpPost("dishes/add")]
        public IActionResult AddDish(Dish ThisDish)
        {
            if(ModelState.IsValid)
            {
                dbContext.Add(ThisDish);
                dbContext.SaveChanges();
                return RedirectToAction("ShowDishes");
            }
            else
            {
                ViewModel AllChefs = new ViewModel ()
                    {
                        AllChefs = dbContext.Chef.ToList()
                    };
                return View("NewDish", AllChefs);
            }
        }

        [HttpGet("dishes/new")]
        public IActionResult ShowNewDish()
        {
            ViewModel AllChefs = new ViewModel ()
                {
                    AllChefs = dbContext.Chef.ToList()

                };
            return View("NewDish", AllChefs);
        }

    }
}
