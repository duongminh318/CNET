using Microsoft.AspNetCore.Mvc;

namespace BookApp.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }

}
