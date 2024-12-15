using Demo.Domain.ApplicationServices.Images;
using DemoApp.Domain.Utility;
using Microsoft.AspNetCore.Http;

namespace Demo.Domain.Utility
{
    public static class StringExtension
    {

        public static string GetImageUrl(this string url, HttpContext context)
        {
            if (string.IsNullOrEmpty(url))
            {
                return string.Empty;

            }

            if (url.Contains("http"))
            {
                return url;
            }
            return $"{context.Request.Scheme}://{context.Request.Host}/{url}";
        }

        public static List<ImageViewModel>? ConvertToImageViewModel(this string imageJson, HttpContext context)
        {
            if (string.IsNullOrEmpty(imageJson))
            {
                return null;
            }

            var result = HelperUtility.DeserializeObject<List<ImageInEntity>>(imageJson).Select(s => new ImageViewModel()
            {
                ImageUrl = s.ImageUrl.GetImageUrl(context),
                ImageId = s.ImageId,
                ImageName = s.ImageName

            }).ToList();
            return result;
        }
    }
}
