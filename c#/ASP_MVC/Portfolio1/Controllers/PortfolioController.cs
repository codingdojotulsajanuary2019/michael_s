using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace Portfolio1.Controllers
{
    public class PortfolioController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View ("Index");
        }

        [HttpGet("projects")]
        public IActionResult Projects()
        {
            return View("Projects");
        }

        [HttpGet("contact")]
        public IActionResult Contact()
        {
            return View("Contact");
        }
    }
}