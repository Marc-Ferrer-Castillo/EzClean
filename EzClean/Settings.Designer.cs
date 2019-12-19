namespace EzClean
{
    partial class Settings
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
            this.pictureBoxCloseSettings = new System.Windows.Forms.PictureBox();
            this.pictureBoxClose = new System.Windows.Forms.PictureBox();
            this.checkedListBoxDirectoriesToClear = new System.Windows.Forms.CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCloseSettings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxCloseSettings
            // 
            this.pictureBoxCloseSettings.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxCloseSettings.Image = global::EzClean.Properties.Resources.exit;
            this.pictureBoxCloseSettings.Location = new System.Drawing.Point(644, 12);
            this.pictureBoxCloseSettings.Name = "pictureBoxCloseSettings";
            this.pictureBoxCloseSettings.Size = new System.Drawing.Size(64, 56);
            this.pictureBoxCloseSettings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCloseSettings.TabIndex = 4;
            this.pictureBoxCloseSettings.TabStop = false;
            this.pictureBoxCloseSettings.Click += new System.EventHandler(this.pictureBoxCloseSettings_Click);
            // 
            // pictureBoxClose
            // 
            this.pictureBoxClose.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxClose.Image = global::EzClean.Properties.Resources.exit;
            this.pictureBoxClose.Location = new System.Drawing.Point(724, 12);
            this.pictureBoxClose.Name = "pictureBoxClose";
            this.pictureBoxClose.Size = new System.Drawing.Size(64, 56);
            this.pictureBoxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxClose.TabIndex = 3;
            this.pictureBoxClose.TabStop = false;
            this.pictureBoxClose.Click += new System.EventHandler(this.pictureBoxClose_Click);
            // 
            // checkedListBoxDirectoriesToClear
            // 
            this.checkedListBoxDirectoriesToClear.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.checkedListBoxDirectoriesToClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.checkedListBoxDirectoriesToClear.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBoxDirectoriesToClear.CheckOnClick = true;
            this.checkedListBoxDirectoriesToClear.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBoxDirectoriesToClear.ForeColor = System.Drawing.SystemColors.Menu;
            this.checkedListBoxDirectoriesToClear.FormattingEnabled = true;
            this.checkedListBoxDirectoriesToClear.Items.AddRange(new object[] {
            "Temporal files from user folder",
            "Temporal files from drive",
            "SoftwareDistribution",
            "Temporary Internet Files",
            "Google Chrome Cache",
            "Windows.old",
            "LiveKernelReports",
            "Prefetch",
            "WER",
            "Minidump",
            "Recycle Bin"});
            this.checkedListBoxDirectoriesToClear.Location = new System.Drawing.Point(26, 119);
            this.checkedListBoxDirectoriesToClear.Name = "checkedListBoxDirectoriesToClear";
            this.checkedListBoxDirectoriesToClear.Size = new System.Drawing.Size(656, 297);
            this.checkedListBoxDirectoriesToClear.TabIndex = 1;
            this.checkedListBoxDirectoriesToClear.SelectedIndexChanged += new System.EventHandler(this.checkedListBoxDirectoriesToClear_SelectedIndexChanged);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(720, 500);
            this.Controls.Add(this.checkedListBoxDirectoriesToClear);
            this.Controls.Add(this.pictureBoxCloseSettings);
            this.Controls.Add(this.pictureBoxClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(720, 500);
            this.MinimumSize = new System.Drawing.Size(720, 500);
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCloseSettings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxClose;
        private System.Windows.Forms.PictureBox pictureBoxCloseSettings;
        private System.Windows.Forms.CheckedListBox checkedListBoxDirectoriesToClear;
    }
}