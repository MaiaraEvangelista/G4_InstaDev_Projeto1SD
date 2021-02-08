using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using G4_InstaDev_Projeto1SD.Models;

namespace G4_InstaDev_Projeto1SD.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return Redirect("~/Home/Login") ;
        }

        public IActionResult Privacy()
        {
            return View();
        }

    }
}

