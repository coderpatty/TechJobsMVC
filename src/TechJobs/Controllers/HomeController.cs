using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace TechJobs.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Dictionary<string, string> actionChoices = new Dictionary<string, string>();
            actionChoices.Add("Search", "search");
            actionChoices.Add("List", "list");
            
            ViewBag.actions = actionChoices;

            return View();
        }
    }
}
