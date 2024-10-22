using BookApp.Services.Authors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BookApp.Controllers
{
    [Authorize]
    public class AuthorController : Controller
    {
        private readonly IAuthorService _authorService;
        private readonly ILogger<HomeController> _logger;
        public AuthorController(ILogger<HomeController> logger, IAuthorService authorService)
        {
            _authorService = authorService;
            _logger = logger;
        }


        public async Task<IActionResult> Index()
        {
            var authors = await _authorService.GetAll();
            return View(authors);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateAuthorViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            try
            {
                await _authorService.Create(model);
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
            }
            return RedirectToAction("Index");

        }

        public async Task<IActionResult> Update(Guid id)
        {
            var author = await _authorService.GetById(id);
            var model = new UpdateAuthorViewModel()
            {
                Id = author.Id,
                Name = author.Name,

            };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Update(UpdateAuthorViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            try
            {
                await _authorService.Update(model);
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> Delete(Guid id)
        {
            try
            {
                await _authorService.Delete(id);
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
            }
            return RedirectToAction("Index");
        }

    }
}