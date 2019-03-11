using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DojoSurveyWithModels.Models;

namespace DojoSurveyWithModels.Controllers
{
    public class HomeController : Controller
    {
        [Route("")]
        [HttpGet]
        public IActionResult Index()
        {
            return View("Index");
        }

        [HttpPost("Submit")]
        public IActionResult Submit(Survey MySurvey)
        {

            return RedirectToAction("Result", MySurvey);
        }

        [HttpGet("Result")]
        public IActionResult Result(Survey MySurvey)
        {
            return View("Result", MySurvey);
        }

    }
}
