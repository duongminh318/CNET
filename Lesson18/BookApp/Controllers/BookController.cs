using BookApp.Controllers;
using BookApp.Services.Authors;
using BookApp.Services.Books;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Ex1RepositoryUOW.Controllers
{
    [Authorize]
    public class BookController : Controller
    {
        private readonly IBookService _bookService;
        private readonly IAuthorService _authorService;
        private readonly ILogger<HomeController> _logger;
        public BookController(ILogger<HomeController> logger, IBookService bookService, IAuthorService authorService)
        {
            _bookService = bookService;
            _authorService = authorService;
            _logger = logger;
        }
      

        public async Task<IActionResult> Index()
        {
            var books = await _bookService.GetAll();
            return View(books);
        }

        public async Task<IActionResult> Create()
        {
            var authors = await _authorService.GetAll();
            return View(authors);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateBookViewModel model)
        {
            if (!ModelState.IsValid)
            {
                SetError(ModelState);
            }
            try
            {
                await _bookService.Create(model);
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
            }
            return RedirectToAction("Index");

        }

        public async Task<IActionResult> Update(Guid id)
        {
            var book = await _bookService.GetById(id);
            var authors = await _authorService.GetAll();
            ViewBag.Authors = authors;
            var model = new UpdateBookViewModel()
            {
                Id = book.Id, 
                Name = book.Name, 
                AuthorId = book.AuthorId
            };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Update(UpdateBookViewModel model)
        {
            if (!ModelState.IsValid)
            {
                SetError(ModelState);
                return RedirectToAction("Error");
            }
            try
            {
                await _bookService.Update(model);
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                SetError(ModelState);
                return RedirectToAction("Error");
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> Delete(Guid id)
        {
            try
            {
                await _bookService.Delete(id);
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
            }
            return RedirectToAction("Index");
        }

        public IActionResult Error()
        {
            return View();
        }

        private void SetError(ModelStateDictionary modelState)
        {
            var errors = new List<string>();
            foreach (var state in modelState.Values)
            {
                foreach (var error in state.Errors)
                {
                    errors.Add(error.ErrorMessage);
                }
            }
            TempData["Error"] = string.Join(";", errors);
           
        }
    }
}