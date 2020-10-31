using DownloadsManager.FileWatcher;
using DownloadsManager.Forms;
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
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            CustomServiceContainer.AddService<IFileManager, FileManager>(new FileManager());
            CustomServiceContainer.AddService<IWeatherApi, WeatherApi>(new WeatherApi());

            MyFileWatcher fw = new MyFileWatcher();
            var frm = new Form1(fw);
            
            Application.Run(frm);
        }
    }
}
