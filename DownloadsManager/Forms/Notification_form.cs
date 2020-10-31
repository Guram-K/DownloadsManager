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
    public partial class Notification_form : Form
    {
        private int x { get; set; }
        private int y { get; set; }
        private string _targetPath { get; set; }

        public Notification_form(string targetPath)
        {
            InitializeComponent();
            _targetPath = targetPath;
        }

        public enum enmAction
        { 
            wait,
            start,
            close
        }

        private Notification_form.enmAction action;

        public void showAlert(string msg, string time)
        {
            this.Opacity = 0.0;
            this.StartPosition = FormStartPosition.Manual;
            string fName;

            for (int i = 1; i < 10; i++)
            {
                fName = "alert" + i.ToString();
                Notification_form frm = (Notification_form)Application.OpenForms[fName];

                if (frm == null)
                {
                    this.Name = fName;
                    this.x = Screen.PrimaryScreen.WorkingArea.Width - this.Width + 15;
                    this.y = Screen.PrimaryScreen.WorkingArea.Height - this.Height * i;
                    this.Location = new Point(this.x, this.y);
                    break;
                }
            }

            this.x = Screen.PrimaryScreen.WorkingArea.Width - base.Width - 5;

            this.lblTitle.Text = msg;
            this.lblTime.Text = time;

            this.Show();
            this.action = enmAction.start;
            this.timer1.Interval = 1;
            this.timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            switch (this.action)
            {
                case enmAction.wait:
                    timer1.Interval = 5000;
                    action = enmAction.close;
                    break;
                case Notification_form.enmAction.start:
                    this.timer1.Interval = 1;
                    this.Opacity += 0.1;
                    if (this.x < this.Location.X)
                    {
                        this.Left--;
                    }
                    else
                    {
                        if (this.Opacity == 1.0)
                        {
                            action = Notification_form.enmAction.wait;
                        }
                    }
                    break;
                case enmAction.close:
                    timer1.Interval = 1;
                    this.Opacity -= 0.1;

                    this.Left -= 3;
                    if (base.Opacity == 0.0)
                    {
                        base.Close();
                    }
                    break;
            }
        }

        private void btnCloseNtf_Click(object sender, EventArgs e)
        {
            timer1.Interval = 1;
            action = enmAction.close;
        }

        private void btnOpenDir_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", _targetPath);
        }
    }
}
