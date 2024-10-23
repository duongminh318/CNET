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

        [HttpPost]
        public async Task<IActionResult> CreateUser(CreateUserViewModel model)
        {
            var user = new IdentityUser
            {
                Email = model.Email,
                UserName = model.UserName
            };
            var result = await _userManager.CreateAsync(user, model.Password);

            if (result.Succeeded)
            {
                var role = await _roleManager.Roles.FirstOrDefaultAsync(s => s.Id == model.RoleId);
                if (role == null)
                {
                    return RedirectToAction("Error", "Home");
                }

                var addRoleResult = await _userManager.AddToRoleAsync(user, role.Name);
                if (addRoleResult.Succeeded)
                {
                    return Redirect("/");
                }
            }
            return RedirectToAction("Error", "Home");
        }


        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            var user = await _userManager.FindByEmailAsync(model.Email);
            if (user == null)
            {
                ModelState.AddModelError(string.Empty, $"user {model.Email} is not found");
                return View(model);
            }

            var result = await _signInManager.PasswordSignInAsync(user, model.Password, model.RememberMe, false);

            if (result.Succeeded)
            {
                return Redirect("/");
            }

            ModelState.AddModelError(string.Empty, "password is not correct");
            return View(model);
        }


    }

}
