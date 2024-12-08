namespace Demo.Domain.InfrastructureServices
{
    public class FileInfoModel
    {
        public string FileName { get; set; }
        public string FilePath { get; set; }

        public FileInfoModel(string fileName, string filePath)
        {
            FileName = fileName;
            FilePath = filePath;
        }
    }
}
