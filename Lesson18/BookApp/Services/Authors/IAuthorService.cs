namespace BookApp.Services.Authors
{
    public interface IAuthorService
    {
        Task<List<AuthorViewModel>> GetAll();
        Task<AuthorViewModel> GetById(Guid id);
        Task Update(UpdateAuthorViewModel model);
        Task Create(CreateAuthorViewModel model);
        Task Delete(Guid id);
    }
}
