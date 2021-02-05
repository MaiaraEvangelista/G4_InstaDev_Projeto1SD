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
<<<<<<< HEAD
            return Redirect("~/Home/Login") ;
=======
            return View();
>>>>>>> feed
        }

        public IActionResult Privacy()
        {
            return View();
        }

<<<<<<< HEAD
=======
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
>>>>>>> feed
    }
}
