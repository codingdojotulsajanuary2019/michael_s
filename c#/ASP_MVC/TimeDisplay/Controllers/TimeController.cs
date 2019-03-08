using System;
using Microsoft.AspNetCore.Mvc;
using System.Threading;
using System.Threading.Tasks;

namespace TimeDisplay
{
    public class TimeController : Controller
    {
        [HttpGet("")]
        public IActionResult Time()
        {
            return View();
        }
    }

}