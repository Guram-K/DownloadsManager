namespace DownloadsManager
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnSettings = new FontAwesome.Sharp.IconButton();
            this.btnStats = new FontAwesome.Sharp.IconButton();
            this.btnDownloads = new FontAwesome.Sharp.IconButton();
            this.btnFolders = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.PictureBox();
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblChildForm = new System.Windows.Forms.Label();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.pnlShadow = new System.Windows.Forms.Panel();
            this.pnlDesktop = new System.Windows.Forms.Panel();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            this.pnlTitle.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panelMenu.Controls.Add(this.btnSettings);
            this.panelMenu.Controls.Add(this.btnStats);
            this.panelMenu.Controls.Add(this.btnDownloads);
            this.panelMenu.Controls.Add(this.btnFolders);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 638);
            this.panelMenu.TabIndex = 0;
            // 
            // btnSettings
            // 
            this.btnSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnSettings.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSettings.IconChar = FontAwesome.Sharp.IconChar.Tools;
            this.btnSettings.IconColor = System.Drawing.Color.Gainsboro;
            this.btnSettings.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSettings.IconSize = 32;
            this.btnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.Location = new System.Drawing.Point(0, 343);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnSettings.Rotation = 0D;
            this.btnSettings.Size = new System.Drawing.Size(220, 60);
            this.btnSettings.TabIndex = 4;
            this.btnSettings.Text = "Settings";
            this.btnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnStats
            // 
            this.btnStats.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStats.FlatAppearance.BorderSize = 0;
            this.btnStats.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStats.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnStats.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnStats.IconChar = FontAwesome.Sharp.IconChar.ChartBar;
            this.btnStats.IconColor = System.Drawing.Color.Gainsboro;
            this.btnStats.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnStats.IconSize = 32;
            this.btnStats.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStats.Location = new System.Drawing.Point(0, 283);
            this.btnStats.Name = "btnStats";
            this.btnStats.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnStats.Rotation = 0D;
            this.btnStats.Size = new System.Drawing.Size(220, 60);
            this.btnStats.TabIndex = 3;
            this.btnStats.Text = "Download Statistics";
            this.btnStats.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStats.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStats.UseVisualStyleBackColor = true;
            this.btnStats.Click += new System.EventHandler(this.btnStats_Click);
            // 
            // btnDownloads
            // 
            this.btnDownloads.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDownloads.FlatAppearance.BorderSize = 0;
            this.btnDownloads.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDownloads.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnDownloads.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDownloads.IconChar = FontAwesome.Sharp.IconChar.CloudDownloadAlt;
            this.btnDownloads.IconColor = System.Drawing.Color.Gainsboro;
            this.btnDownloads.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDownloads.IconSize = 32;
            this.btnDownloads.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDownloads.Location = new System.Drawing.Point(0, 223);
            this.btnDownloads.Name = "btnDownloads";
            this.btnDownloads.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnDownloads.Rotation = 0D;
            this.btnDownloads.Size = new System.Drawing.Size(220, 60);
            this.btnDownloads.TabIndex = 2;
            this.btnDownloads.Text = "Downloads";
            this.btnDownloads.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDownloads.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDownloads.UseVisualStyleBackColor = true;
            this.btnDownloads.Click += new System.EventHandler(this.btnDownloads_Click);
            // 
            // btnFolders
            // 
            this.btnFolders.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFolders.FlatAppearance.BorderSize = 0;
            this.btnFolders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFolders.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnFolders.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnFolders.IconChar = FontAwesome.Sharp.IconChar.Folder;
            this.btnFolders.IconColor = System.Drawing.Color.Gainsboro;
            this.btnFolders.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFolders.IconSize = 32;
            this.btnFolders.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFolders.Location = new System.Drawing.Point(0, 163);
            this.btnFolders.Name = "btnFolders";
            this.btnFolders.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnFolders.Rotation = 0D;
            this.btnFolders.Size = new System.Drawing.Size(220, 60);
            this.btnFolders.TabIndex = 1;
            this.btnFolders.Text = "Folders";
            this.btnFolders.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFolders.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFolders.UseVisualStyleBackColor = true;
            this.btnFolders.Click += new System.EventHandler(this.btnFolders_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.btnHome);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 163);
            this.panelLogo.TabIndex = 0;
            // 
            // btnHome
            // 
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.Location = new System.Drawing.Point(25, 12);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(160, 134);
            this.btnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnHome.TabIndex = 0;
            this.btnHome.TabStop = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // pnlTitle
            // 
            this.pnlTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.pnlTitle.Controls.Add(this.panel1);
            this.pnlTitle.Controls.Add(this.lblChildForm);
            this.pnlTitle.Controls.Add(this.iconCurrentChildForm);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.Location = new System.Drawing.Point(220, 0);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(854, 75);
            this.pnlTitle.TabIndex = 1;
            this.pnlTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTitle_MouseDown);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(740, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(114, 75);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnMinimize);
            this.panel2.Controls.Add(this.btnMaximize);
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(114, 24);
            this.panel2.TabIndex = 0;
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.ForeColor = System.Drawing.Color.Transparent;
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.Location = new System.Drawing.Point(0, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(38, 24);
            this.btnMinimize.TabIndex = 4;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.btnMaximize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.ForeColor = System.Drawing.Color.Transparent;
            this.btnMaximize.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximize.Image")));
            this.btnMaximize.Location = new System.Drawing.Point(38, 0);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(38, 24);
            this.btnMaximize.TabIndex = 3;
            this.btnMaximize.UseVisualStyleBackColor = false;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.Transparent;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(76, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(38, 24);
            this.btnClose.TabIndex = 2;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblChildForm
            // 
            this.lblChildForm.AutoSize = true;
            this.lblChildForm.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblChildForm.Location = new System.Drawing.Point(61, 21);
            this.lblChildForm.Name = "lblChildForm";
            this.lblChildForm.Size = new System.Drawing.Size(35, 13);
            this.lblChildForm.TabIndex = 1;
            this.lblChildForm.Text = "Home";
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.iconCurrentChildForm.ForeColor = System.Drawing.Color.MediumPurple;
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconCurrentChildForm.IconColor = System.Drawing.Color.MediumPurple;
            this.iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(23, 21);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(32, 32);
            this.iconCurrentChildForm.TabIndex = 0;
            this.iconCurrentChildForm.TabStop = false;
            // 
            // pnlShadow
            // 
            this.pnlShadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            this.pnlShadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlShadow.Location = new System.Drawing.Point(220, 75);
            this.pnlShadow.Name = "pnlShadow";
            this.pnlShadow.Size = new System.Drawing.Size(854, 9);
            this.pnlShadow.TabIndex = 2;
            // 
            // pnlDesktop
            // 
            this.pnlDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.pnlDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDesktop.Location = new System.Drawing.Point(220, 84);
            this.pnlDesktop.Name = "pnlDesktop";
            this.pnlDesktop.Size = new System.Drawing.Size(854, 554);
            this.pnlDesktop.TabIndex = 3;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "Downloads Manager";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 638);
            this.Controls.Add(this.pnlDesktop);
            this.Controls.Add(this.pnlShadow);
            this.Controls.Add(this.pnlTitle);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private FontAwesome.Sharp.IconButton btnFolders;
        private FontAwesome.Sharp.IconButton btnStats;
        private FontAwesome.Sharp.IconButton btnDownloads;
        private FontAwesome.Sharp.IconButton btnSettings;
        private System.Windows.Forms.PictureBox btnHome;
        private System.Windows.Forms.Panel pnlTitle;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private System.Windows.Forms.Label lblChildForm;
        private System.Windows.Forms.Panel pnlShadow;
        private System.Windows.Forms.Panel pnlDesktop;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnMaximize;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

