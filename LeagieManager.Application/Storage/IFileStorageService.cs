using System;
using System.Collections.Generic;
using System.Text;

namespace LeagueManager.Application.Storage
{
    public interface IFileStorageService
    {
        Task<string> UploadAsync(Stream file, string fileName);
        Task DeleteAsync(string fileUrl);
    }
}
