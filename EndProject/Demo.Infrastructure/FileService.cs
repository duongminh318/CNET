using Demo.Domain.InfrastructureServices;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

namespace Demo.Infrastructure
{

    public class FileService : IFileService
    {
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly string _webRootFolder;
        public FileService(IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
            _webRootFolder = _webHostEnvironment.WebRootPath;
        }
        public async Task<FileInfoModel> UploadFile(IFormFile file, string folderName)
        {
            string directory = Path.Combine(_webRootFolder, folderName);
            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }
            var fileName = $"{Guid.NewGuid()}-{file.FileName}";
            //  var filePath = $"/{folderName}/{fileName}";
            var filePath = $"{folderName}/{fileName}";
            await using var stream = new FileStream(Path.Combine(directory, fileName), FileMode.Create);
            await file.CopyToAsync(stream);
            return new FileInfoModel(file.FileName, filePath);
        }

        public void Delete(string url)
        {
            string filePath = Path.Combine(_webRootFolder, url);
            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException(filePath);
            }
            File.Delete(filePath);
        }
    }
}
