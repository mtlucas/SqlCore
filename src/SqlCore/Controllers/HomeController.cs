using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SqlCore.Models;
using Microsoft.AspNetCore.Mvc;

namespace SqlCore.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Sample ASP.NET Core MVC application";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Developed by:  Mike Lucas";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
