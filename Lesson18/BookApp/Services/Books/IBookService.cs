namespace BookApp.Services.Books
{
    public interface IBookService
    {
        Task<List<BookViewModel>> GetAll();
        Task<BookViewModel> GetById(Guid id);
        Task Update(UpdateBookViewModel model);
        Task Create(CreateBookViewModel model);
        Task Delete(Guid id);
    }
}
