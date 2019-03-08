using System;
using Microsoft.AspNetCore.Mvc;

namespace RazorFun
{
    public class IndexController : Controller
    {
        [HttpGet("")]
        public IActionResult Home()
        {
            return View();
        }
    }
}