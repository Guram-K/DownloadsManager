using PCL_real.Abstraction.Services;
using ServiceContainer;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace PCL_real.Implementation.Services
{
    public class FileWatcher : IFileWatcher
    {
        private readonly FileSystemWatcher _fileSystemWatcher;

        public FileWatcher()
        {
            _fileSystemWatcher = new FileSystemWatcher(resources.sourcePath);
            _fileSystemWatcher.Created += new FileSystemEventHandler(_fileWatcher_Created);
            _fileSystemWatcher.Changed += new FileSystemEventHandler(_fileWatcher_Created);

            _fileSystemWatcher.EnableRaisingEvents = true;
        }

        private void _fileWatcher_Created(object sender, FileSystemEventArgs e)
        {
            CustomServiceContainer.GetService<IFileManager>().MoveFiles(resources.sourcePath, resources.targetPath);
        }
    }
}
