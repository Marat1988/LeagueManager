using LeagueManager.Application.Storage;
using Microsoft.Extensions.Configuration;

namespace LeagueManager.Infrastructure.Storage
{
    public class LocalFileStorageService : IFileStorageService
    {
        private readonly string _rootPath;

        public LocalFileStorageService(IConfiguration configuration)
        {
            _rootPath = configuration["FileStorage:RootPath"] ?? Path.Combine(Directory.GetCurrentDirectory(), "uploads");

            if (!Directory.Exists(_rootPath))
            {
                Directory.CreateDirectory(_rootPath);
            }
        }

        public Task DeleteAsync(string fileUrl)
        {
            if (File.Exists(fileUrl))
            {
                File.Delete(fileUrl);
            }
            return Task.CompletedTask;
        }

        public async Task<string> UploadAsync(Stream file, string fileName)
        {
            var uniqueName = $"{Guid.NewGuid()}_{fileName}";
            var filePath = Path.Combine(_rootPath, uniqueName);

            using var fileStream = new FileStream(filePath, FileMode.Create, FileAccess.Write);
            await fileStream.CopyToAsync(file);
            return filePath;
        }
    }
}
