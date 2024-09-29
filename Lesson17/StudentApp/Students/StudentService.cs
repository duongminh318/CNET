using StudentApp.Entities;
using Microsoft.EntityFrameworkCore;

namespace StudentApp.Students
{
    public class StudentService : IStudentService
    {
        private readonly ApplicationDbContext _context;
        public StudentService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task Create(CreateStudentViewModel model)
        {
            var Student = new Student()
            {
                Id = Guid.NewGuid(),
                Name = model.Name,
                Score = model.Score
            };
            _context.Students.Add(Student);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(Guid id)
        {
            var Student = await _context.Students.FindAsync(id);
            if (Student == null)
            {
                throw new Exception("Student not found");
            }

            _context.Students.Remove(Student);
            await _context.SaveChangesAsync();
        }

        public async Task<List<StudentViewModel>> GetAll()
        {
            var Students = await _context.Students.Select(s => new StudentViewModel()
            {
                Id = s.Id,
                Name = s.Name,
                Score = s.Score,
            }).ToListAsync();
            return Students;
        }

        public async Task<StudentViewModel> GetById(Guid id)
        {
            var Student = await _context.Students.FindAsync(id);
            if (Student == null)
            {
                throw new Exception("Student not found");
            }

            var result = new StudentViewModel()
            {
                Id = Student.Id,
                Name = Student.Name,
                Score = Student.Score,
            };
            return result;
        }

        public async Task Update(UpdateStudentViewModel model)
        {
            var Student = await _context.Students.FindAsync(model.Id);
            if (Student == null)
            {
                throw new Exception("Student not found");
            }
            Student.Name = model.Name;
            Student.Score = model.Score;
            _context.Students.Update(Student);
            await _context.SaveChangesAsync();
        }
    }
}
