using System;
using Microsoft.AspNetCore.Mvc;


namespace DojoSurvey
{
    public class SurveyController: Controller
    {
        [HttpGet("")]
        public IActionResult Survey()
        {
            return View("Survey");
        }

        [HttpPost("success")]
        public IActionResult Success(string name, string location, string language, string comments)
        {
            ViewBag.Name = name;
            ViewBag.Location = location;
            ViewBag.Language = language;
            ViewBag.Comments = comments;
            
            return View();
        }
    }
}