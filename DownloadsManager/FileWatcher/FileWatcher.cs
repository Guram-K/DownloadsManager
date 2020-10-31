using DownloadsManager.Forms;
using PCL_real.Abstraction.Services;
using ServiceContainer;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DownloadsManager.FileWatcher
{
    public class MyFileWatcher
    {
        public readonly FileSystemWatcher _fileSystemWatcher;

        public MyFileWatcher()
        {
            _fileSystemWatcher = new FileSystemWatcher(resources.sourcePath);
            //_fileSystemWatcher.Created += (sender, e) => _fileWatcher_Created(sender, e);
            _fileSystemWatcher.Changed += (sender, e) => _fileWatcher_Changed(sender, e);
            //_fileSystemWatcher.Deleted += new FileSystemEventHandler(_fileWatcher_Created);
            //_fileSystemWatcher.Renamed += new FileSystemEventHandler(_fileWatcher_Created);

            _fileSystemWatcher.EnableRaisingEvents = true;
            //_fileSystemWatcher.IncludeSubdirectories = true;
        }

        //private async void _fileWatcher_Created(object sender, FileSystemEventArgs e) { }

        private async void _fileWatcher_Changed(object sender, FileSystemEventArgs e)
        {
            var files = await CustomServiceContainer.GetService<IFileManager>().GetDirFiles(resources.sourcePath, resources.targetPath);

            foreach (var file in files)
            {
                var result = await CustomServiceContainer.GetService<IFileManager>().MoveFiles(file, resources.sourcePath, resources.targetPath);
                if (result)
                {
                    Notification_form ntf = new Notification_form(file.TargetPath);
                    ntf.showAlert(file.FileName + " has downloaded", file.Creation.ToString("h:mm tt"));
                }
            }
        }
    }
}
