using PCL_real.Abstraction.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PCL_real.Abstraction.Services
{
    public interface IFileManager
    {
        IEnumerable<IFileType> GetAllFiles(string sourceDir, string targetDir);
        IEnumerable<IFileType> GetDirFiles(string sourceDir, string targetDir);
        void MoveFiles(string sourceDir, string targetDir);
        IEnumerable<IFileType> GetModelList(List<string> files, string sourceDir, string targetDir);
    }
}
