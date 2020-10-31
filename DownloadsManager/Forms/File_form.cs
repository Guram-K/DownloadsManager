using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DownloadsManager.Forms
{
    public partial class File_form : Form
    {
        private string _path { get; set; }
        public File_form(string fileName, string path, string date)
        {
            InitializeComponent();
            btnFile.BringToFront();
            btnFile.Text = fileName;
            lblDate.Text = date;
            _path = path;
        }

        private void btnFile_Click(object sender, EventArgs e)
        {
            lblDate.Focus();
            Process.Start(_path);
        }

        private void btnFile_MouseMove(object sender, MouseEventArgs e)
        {
            toolTip1.UseFading = false;
            toolTip1.OwnerDraw = true;
            toolTip1.BackColor = Color.FromArgb(34, 33, 74);
            toolTip1.ForeColor = Color.White;
            toolTip1.SetToolTip(btnFile, _path);
        }

        private void toolTip1_Draw(object sender, DrawToolTipEventArgs e)
        {
            e.DrawBackground();
            e.DrawText();
        }
    }
}
