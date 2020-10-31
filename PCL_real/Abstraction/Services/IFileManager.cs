using PCL_real.Abstraction.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PCL_real.Abstraction.Services
{
    public interface IFileManager
    {
        IEnumerable<ISavedFileModel> GetAllFiles(string targetPath);
        Task<IEnumerable<IFileModel>> GetDirFiles(string sourcePath, string targetPath);
        Task<bool> MoveFiles(IFileModel file, string sourcePath, string targetPath);
        IEnumerable<IFileModel> GetModelList(List<string> files, string sourcePath, string targetPath);
        IEnumerable<ISavedFileModel> GetSavedModels(List<string> files, string targetPath);
    }
}
