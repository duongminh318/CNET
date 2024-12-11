using Demo.Domain.ApplicationServices.Users;

namespace Demo.Domain.ApplicationServices.Categories
{
    public interface ICategoryService
    {
        Task<ResponseResult> CreateCategory(CreateCategoryViewModel model, UserProfileModel currentUser);
        Task<ResponseResult> UpdateCategory(UpdateCategoryViewModel model, UserProfileModel currentUser);
        Task<ResponseResult> DeleteCategory(Guid categoryId);
        Task<CategoryViewModel> GetCategoryById(Guid categoryId);
        Task<PageResult<CategoryViewModel>> GetCategories(CategorySearchQuery query);
        Task<ResponseResult> UpdateStatus(UpdateStatusViewModel model);

    }
}
