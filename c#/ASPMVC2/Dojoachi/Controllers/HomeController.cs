using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Dojoachi.Models;
using Microsoft.AspNetCore.Http;

namespace Dojoachi.Controllers
{
    public class HomeController : Controller
    {
        [Route("")]
        [HttpGet]
        public IActionResult Index()
        {
            
            if(HttpContext.Session.GetInt32("happiness")== null)
            {
                Pet MyDojoachi = new Pet();
                MyDojoachi.New();
                HttpContext.Session.SetInt32("happiness", MyDojoachi.Happiness);
                HttpContext.Session.SetInt32("fullness", MyDojoachi.Fullness);
                HttpContext.Session.SetInt32("meals", MyDojoachi.Meals);
                HttpContext.Session.SetInt32("energy", MyDojoachi.Energy);
                HttpContext.Session.SetString("Message", "");
                @ViewBag.Happiness = HttpContext.Session.GetInt32("happiness");
                @ViewBag.Fullness = HttpContext.Session.GetInt32("fullness");
                @ViewBag.Meals = HttpContext.Session.GetInt32("meals");
                @ViewBag.Energy = HttpContext.Session.GetInt32("energy");

            }
            else
            {
                int? Happy = HttpContext.Session.GetInt32("happiness");
                int? Full = HttpContext.Session.GetInt32("fullness");
                int? Meals = HttpContext.Session.GetInt32("meals");
                int? Energy = HttpContext.Session.GetInt32("energy");
                string Message = HttpContext.Session.GetString("Message");
                @ViewBag.Happiness = Happy;
                @ViewBag.Fullness = Full;
                @ViewBag.Meals = Meals;
                @ViewBag.Energy = Energy;
                @ViewBag.Message = Message;

                if(Energy >= 100 && Full >= 100 && Happy >=100)
                {
                    return View("Win");
                }
                if(Full <= 0 || Happy <= 0)
                {
                    return View("Lose");
                }
            }
            


            return View("Index");
        }

        [HttpGet("feed")]
        public IActionResult Feed()
        {
            int? MealsLeft = HttpContext.Session.GetInt32("meals");
            if (MealsLeft > 0)
            {
                HttpContext.Session.SetInt32("meals", (int)--MealsLeft);
                Random food = new Random();
                int Amount = food.Next(5,11);
                int? AddFood = HttpContext.Session.GetInt32("fullness");
                HttpContext.Session.SetInt32("fullness", (int)AddFood + Amount);
                int? Happy = HttpContext.Session.GetInt32("happiness");
                int? Full = HttpContext.Session.GetInt32("fullness");
                int? Meals = HttpContext.Session.GetInt32("meals");
                int? Energy = HttpContext.Session.GetInt32("energy");
                string Message = $"You fed your Dojoachi! It's fullness increased by {Amount}";
                HttpContext.Session.GetString("Message");
                HttpContext.Session.SetString("Message", Message);
    
                return RedirectToAction("Index");
            }
            else
            {
                string Message = "You do not have any meals left to feed you Dojoachi";
                HttpContext.Session.GetString("Message");
                HttpContext.Session.SetString("Message", Message);
                return RedirectToAction("Index");
            }

        }

        [HttpGet("play")]
        public IActionResult Play()
        {
            Random chance = new Random();
            int Play = chance.Next(1,5);
            if(Play == 1)
            {
                int? Happy = HttpContext.Session.GetInt32("happiness");
                int? Full = HttpContext.Session.GetInt32("fullness");
                int? Meals = HttpContext.Session.GetInt32("meals");
                int? EnergyLost = HttpContext.Session.GetInt32("energy");
                HttpContext.Session.SetInt32("energy", (int)EnergyLost - 5);
                int? Energy = HttpContext.Session.GetInt32("energy");
                string Message = "Your Dojoachi didn't want to play......Energy -5";
                HttpContext.Session.GetString("Message");
                HttpContext.Session.SetString("Message", Message);

                return RedirectToAction("Index");

            }
            else
            {
                int? Happiness = HttpContext.Session.GetInt32("happiness");
                Random rand = new Random();
                int Amount = rand.Next(5,11);
                HttpContext.Session.SetInt32("happiness", (int)Happiness + Amount);
                int? Happy = HttpContext.Session.GetInt32("happiness");
                int? Full = HttpContext.Session.GetInt32("fullness");
                int? Meals = HttpContext.Session.GetInt32("meals");
                int? EnergyLost = HttpContext.Session.GetInt32("energy");
                HttpContext.Session.SetInt32("energy", (int)EnergyLost - 5);
                int? Energy = HttpContext.Session.GetInt32("energy");
                string Message = $"Your Dojoachi was happy to play! Happiness + {Amount}, Energy -5";
                HttpContext.Session.GetString("Message");
                HttpContext.Session.SetString("Message", Message);

                return RedirectToAction("Index");
            }

        }

        [HttpGet("work")]
        public IActionResult Work()
        {
                Random food = new Random();
                int? Happy = HttpContext.Session.GetInt32("happiness");
                int? Full = HttpContext.Session.GetInt32("fullness");
                int? MealsGained = HttpContext.Session.GetInt32("meals");
                int Amount = food.Next(1,4);
                HttpContext.Session.SetInt32("meals",(int)MealsGained + Amount);
                int? Meals = HttpContext.Session.GetInt32("meals");
                int? EnergyLost = HttpContext.Session.GetInt32("energy");
                HttpContext.Session.SetInt32("energy", (int)EnergyLost-5);
                int? Energy = HttpContext.Session.GetInt32("energy");
                string Message = $"After Working.....Meals +{Amount}, Energy -5";
                HttpContext.Session.GetString("Message");
                HttpContext.Session.SetString("Message", Message);

                return RedirectToAction("Index");
        }

        [HttpGet("sleep")]
        public IActionResult Sleep()
        {
            int? HappyLost = HttpContext.Session.GetInt32("happiness");
            HttpContext.Session.SetInt32("happiness", (int)HappyLost -5);
            int? Happy = HttpContext.Session.GetInt32("happiness");
            int? FullLost = HttpContext.Session.GetInt32("fullness");
            HttpContext.Session.SetInt32("fullness", (int)FullLost -5);
            int? Full = HttpContext.Session.GetInt32("fullness");
            int? Meals = HttpContext.Session.GetInt32("meals");
            int? EnergyGained = HttpContext.Session.GetInt32("energy");
            HttpContext.Session.SetInt32("energy", (int)EnergyGained + 15);
            int? Energy = HttpContext.Session.GetInt32("energy");
            string Message = "After Sleeping Energy +15, Happiness -5, Fullness -5";
            HttpContext.Session.GetString("Message");
            HttpContext.Session.SetString("Message", Message);

            return RedirectToAction("Index");
        }

        [HttpGet("reset")]
        public IActionResult Reset()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }
    }
}
