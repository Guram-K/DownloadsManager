using PCL_real.Abstraction.Models;
using PCL_real.Abstraction.Services;
using PCL_real.Implementation.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace PCL_real.Implementation.Services
{
    public class FileManager : IFileManager
    {
        public IEnumerable<ISavedFileModel> GetAllFiles(string targetPath)
        {
            var AllFiles = new List<string>();

            if (Directory.Exists(targetPath)) 
                AllFiles = Directory.GetFiles(targetPath, "*.*", SearchOption.AllDirectories).ToList();


            return GetSavedModels(AllFiles, targetPath);
        }

        public IEnumerable<IFileModel> GetDirFiles(string sourcePath, string targetPath)
        {
            List<string> files = new List<string>();

            if (Directory.Exists(sourcePath) && Directory.GetFiles(sourcePath).Length > 1)
            {
                files = Directory.GetFiles(sourcePath).ToList();
                List<string> tmps = files.Where(x => x.Contains(".tmp") || x.Contains(".crdownload")).ToList();
                foreach (var tmp in tmps)
                {
                    files.Remove(tmp);
                }

                files.Remove(Path.Combine(sourcePath, "desktop.ini"));
            }

            return GetModelList(files, sourcePath, targetPath);
        }

        public void MoveFiles(string sourcePath, string targetPath)
        {
            var files = GetDirFiles(sourcePath, targetPath); // gets list of files from Downloads folder (list contains full path of every file)

            foreach (var file in files)
            {
                Directory.CreateDirectory(file.TargetPath); // creates folder with name of file extension (if it does not exist) 

                try { File.Move(file.FullSourcePath, file.FullTargetPath); }
                catch (Exception e) { File.WriteAllText(Path.Combine(file.TargetPath, "move_log.txt"), e.Message); }
            }
        }

        private IFileModel ToModel(string fullPath, string sourcePath, string targetPath)
        {
            FileModel fileModel = new FileModel()
            {
                FullSourcePath = fullPath,
                BasePath = sourcePath,
                FileName = Path.GetFileName(fullPath),
                Extension = Path.GetExtension(fullPath).Substring(1),
                TargetPath = Path.Combine(targetPath, Path.GetExtension(fullPath).Substring(1)),
                FullTargetPath = Path.Combine(targetPath, Path.GetExtension(fullPath).Substring(1), Path.GetFileName(fullPath))
            };

            return fileModel;
        }

        private ISavedFileModel ToSavedModel(string fullPath, string targetPath)
        {
            SavedFileModel savedFile = new SavedFileModel()
            {
                FullPath = fullPath,
                FileName = Path.GetFileName(fullPath),
                Extension = Path.GetExtension(fullPath).Substring(1)
            };

            return savedFile;
        }

        public IEnumerable<IFileModel> GetModelList(List<string> files, string sourcePath, string targetPath) 
        {
            foreach (var file in files)
            {
                yield return ToModel(file, sourcePath, targetPath);
            }
        }

        public IEnumerable<ISavedFileModel> GetSavedModels(List<string> files, string targetPath)
        {
            foreach (var file in files)
            {
                yield return ToSavedModel(file, targetPath);
            }
        }
    }
}
