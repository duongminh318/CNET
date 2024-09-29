using Microsoft.AspNetCore.Mvc;
using StudentApp.Students;

namespace LearnDI.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudentService _StudentService;
        private readonly ILogger<StudentController> _logger;
        public StudentController(ILogger<StudentController> logger, IStudentService StudentService)
        {
            _StudentService = StudentService;
            _logger = logger;
        }


        public async Task<IActionResult> Index()
        {
            var Students = await _StudentService.GetAll();
            return View(Students);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateStudentViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            try
            {
                await _StudentService.Create(model);
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
            }
            return RedirectToAction("Index");

        }

        public async Task<IActionResult> Update(Guid id)
        {
            var Student = await _StudentService.GetById(id);
            var model = new UpdateStudentViewModel()
            {
                Id = Student.Id,
                Name = Student.Name,
                Score = Student.Score
            };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Update(UpdateStudentViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            try
            {
                await _StudentService.Update(model);
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
                await _StudentService.Delete(id);
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
            }
            return RedirectToAction("Index");
        }
    }
}