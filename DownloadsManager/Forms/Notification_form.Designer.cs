namespace DownloadsManager.Forms
{
    partial class Notification_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Notification_form));
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnOpenDir = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnCloseNtf = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblTitle.Location = new System.Drawing.Point(52, 12);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(5);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Padding = new System.Windows.Forms.Padding(6, 10, 4, 4);
            this.lblTitle.Size = new System.Drawing.Size(157, 34);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Download Complete";
            // 
            // btnOpenDir
            // 
            this.btnOpenDir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnOpenDir.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnOpenDir.FlatAppearance.BorderSize = 0;
            this.btnOpenDir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenDir.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenDir.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnOpenDir.Location = new System.Drawing.Point(0, 47);
            this.btnOpenDir.Name = "btnOpenDir";
            this.btnOpenDir.Size = new System.Drawing.Size(343, 44);
            this.btnOpenDir.TabIndex = 1;
            this.btnOpenDir.Text = "Open Directory";
            this.btnOpenDir.UseVisualStyleBackColor = true;
            this.btnOpenDir.Click += new System.EventHandler(this.btnOpenDir_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnCloseNtf
            // 
            this.btnCloseNtf.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCloseNtf.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCloseNtf.BackgroundImage")));
            this.btnCloseNtf.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCloseNtf.FlatAppearance.BorderSize = 0;
            this.btnCloseNtf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseNtf.Location = new System.Drawing.Point(319, 1);
            this.btnCloseNtf.Name = "btnCloseNtf";
            this.btnCloseNtf.Size = new System.Drawing.Size(24, 24);
            this.btnCloseNtf.TabIndex = 3;
            this.btnCloseNtf.UseVisualStyleBackColor = true;
            this.btnCloseNtf.Click += new System.EventHandler(this.btnCloseNtf_Click);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Garamond", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblTime.Location = new System.Drawing.Point(273, 32);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(49, 14);
            this.lblTime.TabIndex = 4;
            this.lblTime.Text = "4:49 PM";
            // 
            // Notification_form
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(343, 91);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.btnCloseNtf);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnOpenDir);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Notification_form";
            this.Text = "Notification_form";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnOpenDir;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnCloseNtf;
        private System.Windows.Forms.Label lblTime;
    }
}