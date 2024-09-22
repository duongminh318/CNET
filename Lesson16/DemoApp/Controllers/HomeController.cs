using DemoApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DemoApp.Controllers
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
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
       /* public IActionResult Blog()
        {
            return View();
        }*/

        public IActionResult Blog()
        {
            return View();
            var blog = new BlogViewModel
            {
                Id = Guid.NewGuid(),
                Name = "Hý?ng d?n l?p tr?nh",
                Image = "https://media.istockphoto.com/id/1646501089/photo/closeup-group-of-asian-people-software-developers-using-computer-to-write-code-sitting-at.webp?a=1&b=1&s=612x612&w=0&k=20&c=7OC1ykUyXbgHImSLIevBvmwvbn6K7ys0JZAyvXqf2zQ="
            };
            return View(blog);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
