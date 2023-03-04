using Microsoft.AspNetCore.Mvc;
using SunSeeker.Models;
using SunSeeker.Repositories;
using System.Diagnostics;

namespace SunSeeker.Controllers
{
    public class HomeController : Controller
    {
        private readonly IWeatherRepo _weatherRepo;

        public HomeController(IWeatherRepo weatherRepo)
        {
            _weatherRepo = weatherRepo;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult NewForecast(string location) 
        {
            return View(location);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}