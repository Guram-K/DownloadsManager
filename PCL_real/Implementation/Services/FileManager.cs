using PCL_real.Abstraction.Models;
using PCL_real.Abstraction.Services;
using PCL_real.Implementation.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCL_real.Implementation.Services
{
    //D:\Downloads\.DownloadsManagerBin
    public class FileManager : IFileManager
    {
        public IEnumerable<ISavedFileModel> GetAllFiles(string targetPath)
        {
            var AllFiles = new List<string>();

            if (Directory.Exists(targetPath)) 
                AllFiles = Directory.GetFiles(targetPath, "*.*", SearchOption.AllDirectories).ToList();

            var tmp = AllFiles.Where(x => x.Contains(".ini")).ToList();

            foreach (var file in tmp)
            { AllFiles.Remove(file); }

            return GetSavedModels(AllFiles, targetPath);
        }

        public async Task<IEnumerable<IFileModel>> GetDirFiles(string sourcePath, string targetPath)
        {
            List<string> files = new List<string>();

            if (Directory.Exists(sourcePath))
            {
                var tmp = Directory.GetFiles(sourcePath).ToList();
                var extensions = (await ReadWriter.GetInstance().Read()).ToList();

                foreach (var file in tmp)
                {
                    if (extensions.FirstOrDefault(x => Path.GetExtension(file).Substring(1) == x) != default)
                    {
                        files.Add(file);
                    }
                }
            }

            return GetModelList(files, sourcePath, targetPath);
        }

        public async Task<bool> MoveFiles(IFileModel file, string sourcePath, string targetPath)
        {
            Directory.CreateDirectory(file.TargetPath); // creates folder with name of file extension (if it does not exist) 
            try { File.Move(file.FullSourcePath, file.FullTargetPath); return true; }
            catch (Exception e) { File.WriteAllText(Path.Combine(file.TargetPath, "move_log.txt"), e.Message); }

            return false;
        }

        private IFileModel ToModel(string fullPath, string sourcePath, string targetPath)
        {
            return new FileModel()
            {
                FullSourcePath = fullPath,
                BasePath = sourcePath,
                FileName = Path.GetFileName(fullPath),
                Extension = Path.GetExtension(fullPath).Substring(1),
                TargetPath = Path.Combine(targetPath, Path.GetExtension(fullPath).Substring(1)),
                FullTargetPath = Path.Combine(targetPath, Path.GetExtension(fullPath).Substring(1), Path.GetFileName(fullPath)),
                Creation = File.GetCreationTime(fullPath),
                Modification = File.GetLastWriteTime(fullPath)
            };
        }

        private ISavedFileModel ToSavedModel(string fullPath, string targetPath)
        {
            return new SavedFileModel()
            {
                FullPath = fullPath,
                FileName = Path.GetFileName(fullPath),
                Extension = Path.GetExtension(fullPath).Substring(1),
                Creation = File.GetCreationTime(fullPath),
                Modification = File.GetLastWriteTime(fullPath)
            };
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
