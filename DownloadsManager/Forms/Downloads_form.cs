using DownloadsManager.Forms;
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
        private IEnumerable<ISavedFileModel> _files { get; set; }
        private int alphOrder { get; set; } = 0;
        private int dateOrder { get; set; } = 0;

        public Downloads_form()
        {
            InitializeComponent();
            _files = new List<SavedFileModel>();
            _files = CustomServiceContainer.GetService<IFileManager>().GetAllFiles(resources.targetPath);

            _files = _files.OrderBy(x => x.FileName);
            btnNameSort.Image = resources.up_arrow_sort_8px;
            alphOrder = 1;

            Initialize();
        }

        private void Initialize()
        {
            foreach (var file in _files)
            {
                NewChildForm(new File_form(file.FileName, file.FullPath, file.Modification.ToString("h: mm tt MM/dd/yyyy")), file);
            }
        }

        private void NewChildForm(File_form childForm, ISavedFileModel file)
        {
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Top;
            pnlAllFiles.Controls.Add(childForm);
            pnlAllFiles.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnNameSort_Click(object sender, EventArgs e)
        {
            pnlAllFiles.Controls.Clear();

            if (alphOrder == 1)
            {
                _files = _files.OrderByDescending(x => x.FileName);
                alphOrder = 2;
                btnNameSort.Image = resources.down_arrow_sort_8px;
            }
            else
            {
                _files = _files.OrderBy(x => x.FileName);
                alphOrder = 1;
                dateOrder = 0;
                btnDateSort.Image = null;
                btnNameSort.Image = resources.up_arrow_sort_8px;
            }

            Initialize();
        }

        private void btnDateSort_Click(object sender, EventArgs e)
        {
            pnlAllFiles.Controls.Clear();
            _files = dateOrder == 1 ? _files.OrderByDescending(x => x.Creation) : _files.OrderBy(x => x.Creation);

            if (dateOrder == 1)
            {
                _files = _files.OrderByDescending(x => x.Creation);
                dateOrder = 2;
                
                btnDateSort.Image = resources.down_arrow_sort_8px;
            }
            else
            {
                _files = _files.OrderBy(x => x.Creation);
                dateOrder = 1;
                alphOrder = 0;
                btnNameSort.Image = null;
                btnDateSort.Image = resources.up_arrow_sort_8px;
            }
            Initialize();
        }
    }
}
