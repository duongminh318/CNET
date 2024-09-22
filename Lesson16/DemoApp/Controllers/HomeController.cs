using DemoApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DemoApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly List<BlogViewModel> _blogList;
        public HomeController(ILogger<HomeController> logger)
        {
            _blogList = new List<BlogViewModel>()
            {
                new BlogViewModel
                {
                 Id = Guid.Parse("c02300aa-11d6-44b8-9f8a-92b97a333721"),
                 Name = "Hướng dẫn lập trình",
                 Image = "https://media.istockphoto.com/id/1646501089/photo/closeup-group-of-asian-people-software-developers-using-computer-to-write-code-sitting-at.webp?a=1&b=1&s=612x612&w=0&k=20&c=7OC1ykUyXbgHImSLIevBvmwvbn6K7ys0JZAyvXqf2zQ="
                },

                 new BlogViewModel
                {
                 Id = Guid.Parse("ccb61820-b975-45b7-8b3d-bc2d78ce9f2e"),
                 Name = "Hướng dẫn lập trình",
                 Image = "https://media.istockphoto.com/id/1646501089/photo/closeup-group-of-asian-people-software-developers-using-computer-to-write-code-sitting-at.webp?a=1&b=1&s=612x612&w=0&k=20&c=7OC1ykUyXbgHImSLIevBvmwvbn6K7ys0JZAyvXqf2zQ="
                },

                  new BlogViewModel
                {
                 Id = Guid.Parse("32b2decd-6ba9-4544-880a-b6e8d2c4e314"),
                 Name = "Hướng dẫn lập trình",
                 Image = "https://media.istockphoto.com/id/1646501089/photo/closeup-group-of-asian-people-software-developers-using-computer-to-write-code-sitting-at.webp?a=1&b=1&s=612x612&w=0&k=20&c=7OC1ykUyXbgHImSLIevBvmwvbn6K7ys0JZAyvXqf2zQ="
                },
                   new BlogViewModel
                {
                 Id = Guid.Parse("c6442127-afde-42f1-bcc6-17c9243c4edb"),
                 Name = "Hướng dẫn lập trình",
                 Image = "https://media.istockphoto.com/id/1646501089/photo/closeup-group-of-asian-people-software-developers-using-computer-to-write-code-sitting-at.webp?a=1&b=1&s=612x612&w=0&k=20&c=7OC1ykUyXbgHImSLIevBvmwvbn6K7ys0JZAyvXqf2zQ="
                },

            };
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Blog()
        {
            /* var blog = new BlogViewModel
             {
                 Id = Guid.NewGuid(),
                 Name = "Hướng dẫn lập trình",
                 Image = "https://media.istockphoto.com/id/1646501089/photo/closeup-group-of-asian-people-software-developers-using-computer-to-write-code-sitting-at.webp?a=1&b=1&s=612x612&w=0&k=20&c=7OC1ykUyXbgHImSLIevBvmwvbn6K7ys0JZAyvXqf2zQ="
             };
             return View(blog);*/
            return View(_blogList);
        }

        public IActionResult BlogDetail(Guid id)
        {
            var blog = _blogList.FirstOrDefault(s => s.Id == id);
            return View(blog);
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
