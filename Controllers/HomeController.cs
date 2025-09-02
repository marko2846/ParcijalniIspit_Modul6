using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ParcijalniIspit6.Models;

namespace ParcijalniIspit6.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public HomeController()
        {
        }

        public IActionResult Index()
        {
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

        public ActionResult CheckCountValue(int i)
        {
            if(i < 20)
            {
                // Zamislite da ovdje ide neka poslovna logika
            }
            else
            {
                throw (new Exception("Broj je izvan raspona"));
            }
            return View();
        }
    }
}
