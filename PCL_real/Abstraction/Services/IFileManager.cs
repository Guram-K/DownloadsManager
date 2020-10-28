using PCL_real.Abstraction.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PCL_real.Abstraction.Services
{
    public interface IFileManager
    {
        IEnumerable<ISavedFileModel> GetAllFiles(string targetPath);
        IEnumerable<IFileModel> GetDirFiles(string sourcePath, string targetPath);
        void MoveFiles(string sourcePath, string targetPath);
        IEnumerable<IFileModel> GetModelList(List<string> files, string sourcePath, string targetPath);
        IEnumerable<ISavedFileModel> GetSavedModels(List<string> files, string targetPath);
    }
}
