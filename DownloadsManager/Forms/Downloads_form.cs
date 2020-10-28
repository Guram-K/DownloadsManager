using PCL_real.Abstraction.Models;
using PCL_real.Abstraction.Services;
using PCL_real.Implementation.Models;
using ServiceContainer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DownloadsManager
{
    public partial class Downloads_form : Form
    {
        private IEnumerable<ISavedFileModel> _files;
        public Downloads_form()
        {
            InitializeComponent();
            _files = new List<SavedFileModel>();
            _files = CustomServiceContainer.GetService<IFileManager>().GetAllFiles(resources.targetPath);
        }
    }
}
