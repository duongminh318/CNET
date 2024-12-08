using Demo.Domain.ApplicationServices.Images;
using Demo.Domain.ApplicationServices.Users;
using Microsoft.AspNetCore.Http;

namespace Demo.Domain.ApplicationServices.Images
{
    public interface IImageService
    {
        Task<PageResult<ImageViewModel>> GetImages(ImageSearchQuery query);
        Task<ResponseResult> UploadImages(UploadImageViewModel model, UserProfileModel? currentUser = null);

        Task<ResponseResult> UpdateImage(UpdateImageViewModel model, UserProfileModel? currentUser = null);
        Task<ResponseResult> DeleteImage(Guid imageId);

        Task<ResponseResult> UpdateStatus(UpdateStatusViewModel model);
    }
}
