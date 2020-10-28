using DownloadsManager.Forms;
using PCL_real.Abstraction.Services;
using ServiceContainer;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DownloadsManager.FileWatcher
{
    public class MyFileWatcher
    {
        private readonly FileSystemWatcher _fileSystemWatcher;

        public MyFileWatcher()
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
