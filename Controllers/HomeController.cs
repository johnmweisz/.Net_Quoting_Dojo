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
        public IActionResult Index()
        {
            List<Dictionary<string, object>> AllQuotes = DbConnector.Query("SELECT * FROM quote");
            ViewBag.Quotes = AllQuotes;
            return View();
        }
        [HttpPost("quotes")]
        public IActionResult Create(Quote form)
        {
            string query = $"INSERT INTO quote (name, quote) VALUES ('{form.name}', '{form.quote}')";
            DbConnector.Execute(query);
            return RedirectToAction("Index");
        }
    }
}
