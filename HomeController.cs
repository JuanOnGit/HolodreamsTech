using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Holodreams_Tech.Models;

namespace Holodreams_Tech.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "This site is dedicated to any newcomers to technology, software, and design. " +
                "My efforts are with the hope with some chatter that I can provide some basic knowledge, so that " + 
                "whether the just curious or apprentices can better form opinion about what they do. Lastly,  a " + "" +
                "stronger voice within the world of technology that reaches the heavens and explores the mind, creating holo dreams….";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Juan Davila \n" + "Phone: 402-216-0809";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
