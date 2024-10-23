using BookApp.Services.Accounts;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OutputCaching;
using Microsoft.EntityFrameworkCore;


namespace BookApp.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly SignInManager<IdentityUser> _signInManager;

        public AccountController(UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager, SignInManager<IdentityUser> signInManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _signInManager = signInManager;
        }


        public IActionResult Login()
        {
            return View();
        }

        public IActionResult CreateRole()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateRole(CreateRoleViewModel model)
        {
            var role = new IdentityRole();
            role.Name = model.RoleName;
            var result = await _roleManager.CreateAsync(role);
            if (result.Succeeded)
            {
                return Redirect("/");
            }
            else
            {
                return RedirectToAction("Error", "Home");
            }

        }
        public async Task<IActionResult> CreateUser()
        {
            var roles = await _roleManager.Roles.ToListAsync();
            ViewBag.Roles = roles;
            return View();
        }



    }

}
