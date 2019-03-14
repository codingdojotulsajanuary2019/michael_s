using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CrudDelicious.Models;
using Microsoft.EntityFrameworkCore;

namespace CrudDelicious.Controllers
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
            AllDishes ListOfDishes = new AllDishes()
            {
                alldishes = dbContext.Dishes.OrderByDescending(dish => dish.CreatedAt).ToList()

            };
            return View("Index", ListOfDishes);
        }

        [HttpGet("new")]
        public IActionResult ViewNewDish()
        {
            return View("New");
        }
        [HttpPost("new/add")]
        public IActionResult CreateNewDish(Dish newDish)
        {
            if(ModelState.IsValid)
                {
                    dbContext.Add(newDish);
                    dbContext.SaveChanges();
                    return RedirectToAction("Index");
                }
            else
                {
                    return View("New");
                }
        }

        [HttpGet("edit/{id}")]
        public IActionResult ViewEditDish(int id)
        {
            Dish GetDish = dbContext.Dishes.FirstOrDefault(dish => dish.DishID == id);
            return View("Edit", GetDish);
        }

        [HttpPost("edit/update/{id}")]
        public IActionResult UpdateDish(int id, Dish DishToUpdate)
        {
            Dish GetDish = dbContext.Dishes.FirstOrDefault(dish => dish.DishID == id);
            GetDish.Chef = DishToUpdate.Chef;
            GetDish.Name = DishToUpdate.Name;
            GetDish.Calories = DishToUpdate.Calories;
            GetDish.Tastiness = DishToUpdate.Tastiness;
            GetDish.Description = DishToUpdate.Description;
            GetDish.UpdatedAt = DateTime.Now;
            dbContext.SaveChanges();
            return RedirectToAction("ViewDish", id);
        }

        [HttpGet("view/{id}")]
        public IActionResult ViewDish(int id)
        {
            Dish GetDish = dbContext.Dishes.FirstOrDefault(dish => dish.DishID == id);
            return View("View", GetDish);
        }

    }
}
