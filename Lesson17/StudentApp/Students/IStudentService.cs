namespace StudentApp.Students
{
    public interface IStudentService
    {
        Task<List<StudentViewModel>> GetAll();
        Task<StudentViewModel> GetById(Guid id);
        Task Update(UpdateStudentViewModel model);
        Task Create(CreateStudentViewModel model);
        Task Delete(Guid id);
    }
}
