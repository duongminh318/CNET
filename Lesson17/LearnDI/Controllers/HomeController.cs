using LearnDI.Models;
using LearnDI.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace LearnDI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ServiceA _serviceA;
        private readonly ServiceA _serviceA1;
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            _serviceA = new ServiceA();
            _serviceA1 = new ServiceA();
        }

        public IActionResult Index()
        {
            var id = _serviceA.GetId();
            var id1 = _serviceA1.GetId();
            ViewBag.Id = id;
            ViewBag.Id1 = id1;

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
