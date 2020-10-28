using DownloadsManager.FileWatcher;
using PCL_real;
using PCL_real.Abstraction.Services;
using PCL_real.Implementation.Services;
using ServiceContainer;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DownloadsManager
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            CustomServiceContainer.AddAsSignleton<IFileManager, FileManager>(new FileManager());
            MyFileWatcher fe = new MyFileWatcher();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
