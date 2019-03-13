using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using QuotingDojo.Models;
using DbConnection;

namespace QuotingDojo.Controllers
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
        public IActionResult Submit(Quotes input)
        {
            if(ModelState.IsValid)
            {
                string query = $"INSERT INTO Quotes (name, quote) VAlUES ('{input.Name}', '{input.Quote}')";
                DbConnector.Execute(query);
                return Redirect("quotes");
            }
            else
            {
                return View("Index");
            }

        }
        [HttpGet("quotes")]
        public IActionResult ViewQuotes()
        {
            List<Dictionary<string, object>> AllQuotes = DbConnector.Query("SELECT * FROM Quotes ORDER BY create_at DESC");
            ViewBag.Quotes = AllQuotes;
            return View("Quotes");
        }


    }
}
