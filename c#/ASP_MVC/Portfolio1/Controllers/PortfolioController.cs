using System;
using Microsoft.AspNetCore.Mvc;

namespace Portfolio1.Controllers
{
    public class PortfolioController : Controller
    {
        [HttpGet("")]
        public string Index()
        {
            return "This is My Home Index";
        }

        [HttpGet("projects")]
        public string Projects()
        {
            return "This is my projects page";
        }

        [HttpGet("contact")]
        public string Contact()
        {
            return "This is my Contact page";
        }
    }
}