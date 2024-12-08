using Microsoft.AspNetCore.Http;

namespace Demo.Domain.InfrastructureServices
{
    public interface IFileService
    {
        Task<FileInfoModel> UploadFile(IFormFile file, string folderName);
        void Delete(string url);
    }
}
