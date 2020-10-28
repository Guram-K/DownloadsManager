using PCL_real.Abstraction.Services;
using PCL_real.Implementation.Services;
using ServiceContainer;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PCL_real
{
    public static class Initializer
    {
        public static void InitializeServiceContainer()
        {
            CustomServiceContainer.AddService<IFileManager, FileManager>(new FileManager());
            CustomServiceContainer.AddService<IFileWatcher, FileWatcher>(new FileWatcher());
        }

        public static void GetResources()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            const string NAME = "PCL_real.resources.resx";

            using (Stream stream = assembly.GetManifestResourceStream(NAME))
            {
                
            }
        }
    }
}
