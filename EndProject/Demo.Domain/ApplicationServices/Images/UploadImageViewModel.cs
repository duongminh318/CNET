using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace Demo.Domain.ApplicationServices.Images
{
    public class UploadImageViewModel
    {
        [Required]
        public List<IFormFile> Images { get; set; }
    }
}
