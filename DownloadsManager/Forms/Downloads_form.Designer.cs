namespace DownloadsManager
{
    partial class Downloads_form
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
            this.pnlDownloads = new System.Windows.Forms.Panel();
            this.pnlAllFiles = new System.Windows.Forms.Panel();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.pnlNameSort = new System.Windows.Forms.Panel();
            this.btnNameSort = new System.Windows.Forms.Button();
            this.pnlDateSort = new System.Windows.Forms.Panel();
            this.btnDateSort = new System.Windows.Forms.Button();
            this.pnlDownloads.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.pnlNameSort.SuspendLayout();
            this.pnlDateSort.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDownloads
            // 
            this.pnlDownloads.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlDownloads.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.pnlDownloads.Controls.Add(this.pnlAllFiles);
            this.pnlDownloads.Controls.Add(this.pnlTop);
            this.pnlDownloads.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDownloads.Location = new System.Drawing.Point(0, 0);
            this.pnlDownloads.Name = "pnlDownloads";
            this.pnlDownloads.Size = new System.Drawing.Size(800, 450);
            this.pnlDownloads.TabIndex = 0;
            // 
            // pnlAllFiles
            // 
            this.pnlAllFiles.AutoScroll = true;
            this.pnlAllFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAllFiles.Location = new System.Drawing.Point(0, 28);
            this.pnlAllFiles.Name = "pnlAllFiles";
            this.pnlAllFiles.Size = new System.Drawing.Size(800, 422);
            this.pnlAllFiles.TabIndex = 1;
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.pnlNameSort);
            this.pnlTop.Controls.Add(this.pnlDateSort);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(800, 28);
            this.pnlTop.TabIndex = 0;
            // 
            // pnlNameSort
            // 
            this.pnlNameSort.Controls.Add(this.btnNameSort);
            this.pnlNameSort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlNameSort.Location = new System.Drawing.Point(0, 0);
            this.pnlNameSort.Name = "pnlNameSort";
            this.pnlNameSort.Size = new System.Drawing.Size(625, 28);
            this.pnlNameSort.TabIndex = 1;
            // 
            // btnNameSort
            // 
            this.btnNameSort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.btnNameSort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNameSort.FlatAppearance.BorderSize = 0;
            this.btnNameSort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNameSort.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btnNameSort.Location = new System.Drawing.Point(0, 0);
            this.btnNameSort.Name = "btnNameSort";
            this.btnNameSort.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnNameSort.Size = new System.Drawing.Size(625, 28);
            this.btnNameSort.TabIndex = 0;
            this.btnNameSort.Text = "Name";
            this.btnNameSort.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNameSort.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnNameSort.UseVisualStyleBackColor = false;
            this.btnNameSort.Click += new System.EventHandler(this.btnNameSort_Click);
            // 
            // pnlDateSort
            // 
            this.pnlDateSort.Controls.Add(this.btnDateSort);
            this.pnlDateSort.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlDateSort.Location = new System.Drawing.Point(625, 0);
            this.pnlDateSort.Name = "pnlDateSort";
            this.pnlDateSort.Size = new System.Drawing.Size(175, 28);
            this.pnlDateSort.TabIndex = 0;
            // 
            // btnDateSort
            // 
            this.btnDateSort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.btnDateSort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDateSort.FlatAppearance.BorderSize = 0;
            this.btnDateSort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDateSort.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btnDateSort.Location = new System.Drawing.Point(0, 0);
            this.btnDateSort.Name = "btnDateSort";
            this.btnDateSort.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnDateSort.Size = new System.Drawing.Size(175, 28);
            this.btnDateSort.TabIndex = 0;
            this.btnDateSort.Text = "Date";
            this.btnDateSort.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDateSort.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnDateSort.UseVisualStyleBackColor = false;
            this.btnDateSort.Click += new System.EventHandler(this.btnDateSort_Click);
            // 
            // Downloads_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlDownloads);
            this.Name = "Downloads_form";
            this.Text = "Downloads_form";
            this.pnlDownloads.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.pnlNameSort.ResumeLayout(false);
            this.pnlDateSort.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDownloads;
        private System.Windows.Forms.Panel pnlAllFiles;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Panel pnlNameSort;
        private System.Windows.Forms.Button btnNameSort;
        private System.Windows.Forms.Panel pnlDateSort;
        private System.Windows.Forms.Button btnDateSort;
    }
}