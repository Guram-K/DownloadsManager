namespace DownloadsManager.Forms
{
    partial class File_form
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
            this.lblDate = new System.Windows.Forms.Label();
            this.pnlDATE = new System.Windows.Forms.Panel();
            this.btnFile = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pnlDATE.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDate
            // 
            this.lblDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblDate.Location = new System.Drawing.Point(0, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(175, 43);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "4:53 PM 10/31/2020";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlDATE
            // 
            this.pnlDATE.Controls.Add(this.lblDate);
            this.pnlDATE.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlDATE.Location = new System.Drawing.Point(573, 0);
            this.pnlDATE.Name = "pnlDATE";
            this.pnlDATE.Size = new System.Drawing.Size(175, 43);
            this.pnlDATE.TabIndex = 3;
            // 
            // btnFile
            // 
            this.btnFile.AutoSize = true;
            this.btnFile.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFile.FlatAppearance.BorderSize = 0;
            this.btnFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFile.ForeColor = System.Drawing.SystemColors.Control;
            this.btnFile.Image = global::DownloadsManager.resources.iconFile24;
            this.btnFile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFile.Location = new System.Drawing.Point(0, 0);
            this.btnFile.Name = "btnFile";
            this.btnFile.Size = new System.Drawing.Size(748, 43);
            this.btnFile.TabIndex = 0;
            this.btnFile.Text = "Sample text";
            this.btnFile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFile.UseVisualStyleBackColor = true;
            this.btnFile.Click += new System.EventHandler(this.btnFile_Click);
            this.btnFile.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnFile_MouseMove);
            // 
            // toolTip1
            // 
            this.toolTip1.Draw += new System.Windows.Forms.DrawToolTipEventHandler(this.toolTip1_Draw);
            // 
            // File_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(748, 43);
            this.Controls.Add(this.pnlDATE);
            this.Controls.Add(this.btnFile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "File_form";
            this.Text = "File_form";
            this.pnlDATE.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Panel pnlDATE;
        private System.Windows.Forms.Button btnFile;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}