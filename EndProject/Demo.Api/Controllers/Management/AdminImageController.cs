using Demo.Api.Base;
using Demo.Api.Filters;
using Demo.Domain;
using Demo.Domain.ApplicationServices.Images;
using Demo.Domain.Utility;
using Microsoft.AspNetCore.Mvc;

namespace Demo.Api.Management
{

    public class AdminImageController : AuthorizeController
    {
        private readonly IImageService _imageService;
        public AdminImageController(IImageService imageService)
        {
            _imageService = imageService;
        }

        [Permission(CommonConstants.Permissions.ADD_IMAGE_PERMISSION)]
        [HttpPost]
        [Route("upload-images")]
        public async Task<ResponseResult> UploadImages([FromForm] UploadImageViewModel model)
        {
            var result = await _imageService.UploadImages(model);
            return result;
        }

        [Permission(CommonConstants.Permissions.UPDATE_IMAGE_PERMISSION)]
        [HttpPut]
        [Route("update-image")]
        public async Task<ResponseResult> UpdateImage([FromForm] UpdateImageViewModel model)
        {
            var result = await _imageService.UpdateImage(model);
            return result;
        }

        [Permission(CommonConstants.Permissions.DELETE_IMAGE_PERMISSION)]
        [HttpDelete]
        [Route("delete-image")]
        public async Task<ResponseResult> DeleteImage(Guid imageId)
        {
            var result = await _imageService.DeleteImage(imageId);
            return result;
        }
    }
}
