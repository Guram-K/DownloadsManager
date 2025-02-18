﻿

using DownloadsManager.FileWatcher;
using DownloadsManager.Forms;
using FontAwesome.Sharp;
using PCL_real.Abstraction.Models;
using PCL_real.Abstraction.Services;
using ServiceContainer;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace DownloadsManager
{
    public partial class Form1 : Form
    {
        private IconButton currentButton;
        private Panel leftBorderbtn;
        private Form currentChildForm;

        public Form1(MyFileWatcher fw)
        {
            InitializeComponent();
            leftBorderbtn = new Panel();
            leftBorderbtn.Size = new Size(7,60);
            panelMenu.Controls.Add(leftBorderbtn);
            panelMenu.Controls.Add(leftBorderbtn);

            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            notifyIcon1.Visible = false;
            //this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

            fw._fileSystemWatcher.SynchronizingObject = this;

            InitComponents();
        }

        private void InitComponents()
        {
            timer1.Start();
            lblDate.Text = DateTime.Now.ToString("dd MMMM yyyy");
            SetStats();
            SetWeather();
        }

        private async void SetWeather()
        {
            try
            {
                var data = await CustomServiceContainer.GetService<IWeatherApi>().GetWeatherData(resources.city, resources.weatherApiKey);
                var dto = CustomServiceContainer.GetService<IWeatherApi>().GetWeatherDto(data);
                SetValuesW(dto);
            }
            catch (Exception)
            {
                SetDefValuesW();
            }
        }

        private void SetValuesW(IWeatherDto dto)
        {
            lblCity.Text = dto.name;
            lblWeatherDesc.Text = $"Desc: {dto.weather.First().description}";
            lblTemp.Text = $"Temp: {(dto.main.temp - 273.15).ToString()}°C";
            pcbWeather.Image = Image.FromStream(CustomServiceContainer.GetService<IWeatherApi>().GetWeatherIcon(dto.weather.First().icon));
        }

        private void SetDefValuesW()
        {
            lblCity.Text = resources.city;
            lblWeatherDesc.Text = $"Desc: no connection";
            lblTemp.Text = $"Temp: no connection";
        }

        private void SetStats()
        {
            var rm = new Statistics_form(8, false);
            rm.TopLevel = false;
            rm.FormBorderStyle = FormBorderStyle.None;
            rm.Dock = DockStyle.Fill;
            pnlStatsOnHome.Controls.Add(rm);
            pnlStatsOnHome.Tag = rm;
            rm.BringToFront();
            rm.Show();
        }

        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }

        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                currentButton = (IconButton)senderBtn;
                currentButton.BackColor = Color.FromArgb(37, 36, 81);
                currentButton.ForeColor = color;
                currentButton.TextAlign = ContentAlignment.MiddleCenter;
                currentButton.IconColor = color;
                currentButton.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentButton.ImageAlign = ContentAlignment.MiddleRight;

                leftBorderbtn.BackColor = color;
                leftBorderbtn.Location = new Point(0, currentButton.Location.Y);
                leftBorderbtn.Visible = true;
                leftBorderbtn.BringToFront();

                iconCurrentChildForm.IconChar = currentButton.IconChar;
                iconCurrentChildForm.IconColor = color;
            }
        }

        private void DisableButton()
        {
            if (currentButton != null)
            {
                currentButton.BackColor = Color.FromArgb(31, 30, 68);
                currentButton.ForeColor = Color.Gainsboro;
                currentButton.TextAlign = ContentAlignment.MiddleLeft;
                currentButton.IconColor = Color.Gainsboro;
                currentButton.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentButton.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void OpenChildForm(Form childForm, string title)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }

            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlDesktop.Controls.Add(childForm);
            pnlDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblChildForm.Text = title;
        }

        private void btnFolders_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color6);
            OpenChildForm(new Folders_form(), (sender as Button).Text);
        }

        private void btnDownloads_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            OpenChildForm(new Downloads_form(), (sender as Button).Text);
        }

        private void btnStats_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            OpenChildForm(new Statistics_form(12, true), (sender as Button).Text);
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color5);
            OpenChildForm(new Settings_form(), (sender as Button).Text);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            if (currentChildForm != null)
                currentChildForm.Close();
            Reset();
        }

        private void Reset()
        {
            DisableButton();
            leftBorderbtn.Visible = false;
            iconCurrentChildForm.IconChar = IconChar.Home;
            iconCurrentChildForm.IconColor = Color.MediumPurple;
            lblChildForm.Text = "Home";
        }


        //Drag via Title panel
        [DllImport("User32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("User32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void pnlTitle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;

            TrayMinimizerForm_Resize(sender, e);
        }

        private void TrayMinimizerForm_Resize(object sender, EventArgs e)
        {
            notifyIcon1.BalloonTipTitle = "Minimize to Tray App";
            notifyIcon1.BalloonTipText = "You have successfully minimized your form.";

            if (FormWindowState.Minimized == this.WindowState)
            {
                notifyIcon1.Visible = true;
                notifyIcon1.Icon = resources.iconFolder;
                this.ShowInTaskbar = false;
                this.Hide();
            }
            else if (FormWindowState.Normal == this.WindowState)
            {
                notifyIcon1.Visible = false;
            }
        }

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = true;
            notifyIcon1.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            this.lblClock.Text = dateTime.ToString("h:mm:ss tt");
        }
    }
}
