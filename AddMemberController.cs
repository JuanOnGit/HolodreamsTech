using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Holodreams_Tech.Controllers
{
    public class AddMemberController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}