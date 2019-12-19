namespace EzClean
{
    partial class EzClean
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnClean = new System.Windows.Forms.PictureBox();
            this.labelDir = new System.Windows.Forms.Label();
            this.pictureBoxClose = new System.Windows.Forms.PictureBox();
            this.pictureBoxSettings = new System.Windows.Forms.PictureBox();
            this.labelEzClean = new System.Windows.Forms.Label();
            this.circularProgressBar = new CircularProgressBar.CircularProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnClean)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSettings)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClean
            // 
            this.btnClean.BackColor = System.Drawing.Color.Transparent;
            this.btnClean.Location = new System.Drawing.Point(233, 127);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(254, 253);
            this.btnClean.TabIndex = 0;
            this.btnClean.TabStop = false;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // labelDir
            // 
            this.labelDir.AutoSize = true;
            this.labelDir.BackColor = System.Drawing.Color.Transparent;
            this.labelDir.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelDir.Location = new System.Drawing.Point(163, 478);
            this.labelDir.Name = "labelDir";
            this.labelDir.Size = new System.Drawing.Size(0, 13);
            this.labelDir.TabIndex = 1;
            // 
            // pictureBoxClose
            // 
            this.pictureBoxClose.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxClose.Image = global::EzClean.Properties.Resources.exit;
            this.pictureBoxClose.Location = new System.Drawing.Point(644, 12);
            this.pictureBoxClose.Name = "pictureBoxClose";
            this.pictureBoxClose.Size = new System.Drawing.Size(64, 56);
            this.pictureBoxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxClose.TabIndex = 2;
            this.pictureBoxClose.TabStop = false;
            this.pictureBoxClose.Click += new System.EventHandler(this.pictureBoxClose_Click);
            // 
            // pictureBoxSettings
            // 
            this.pictureBoxSettings.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxSettings.Image = global::EzClean.Properties.Resources.settings;
            this.pictureBoxSettings.Location = new System.Drawing.Point(590, 12);
            this.pictureBoxSettings.Name = "pictureBoxSettings";
            this.pictureBoxSettings.Size = new System.Drawing.Size(48, 56);
            this.pictureBoxSettings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxSettings.TabIndex = 3;
            this.pictureBoxSettings.TabStop = false;
            this.pictureBoxSettings.Click += new System.EventHandler(this.pictureBoxSettings_Click);
            // 
            // labelEzClean
            // 
            this.labelEzClean.AutoSize = true;
            this.labelEzClean.BackColor = System.Drawing.Color.Transparent;
            this.labelEzClean.Font = new System.Drawing.Font("Cambria", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEzClean.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelEzClean.Location = new System.Drawing.Point(283, 27);
            this.labelEzClean.Name = "labelEzClean";
            this.labelEzClean.Size = new System.Drawing.Size(161, 41);
            this.labelEzClean.TabIndex = 6;
            this.labelEzClean.Text = "EzCLEAN";
            // 
            // circularProgressBar
            // 
            this.circularProgressBar.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.circularProgressBar.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circularProgressBar.AnimationSpeed = 100;
            this.circularProgressBar.BackColor = System.Drawing.Color.Transparent;
            this.circularProgressBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold);
            this.circularProgressBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.circularProgressBar.InnerColor = System.Drawing.Color.Transparent;
            this.circularProgressBar.InnerMargin = 2;
            this.circularProgressBar.InnerWidth = -1;
            this.circularProgressBar.Location = new System.Drawing.Point(199, 93);
            this.circularProgressBar.MarqueeAnimationSpeed = 10;
            this.circularProgressBar.Name = "circularProgressBar";
            this.circularProgressBar.OuterColor = System.Drawing.Color.Transparent;
            this.circularProgressBar.OuterMargin = 0;
            this.circularProgressBar.OuterWidth = 26;
            this.circularProgressBar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.circularProgressBar.ProgressWidth = 25;
            this.circularProgressBar.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.circularProgressBar.Size = new System.Drawing.Size(320, 320);
            this.circularProgressBar.StartAngle = 270;
            this.circularProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.circularProgressBar.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circularProgressBar.SubscriptText = ".23";
            this.circularProgressBar.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circularProgressBar.SuperscriptText = "°C";
            this.circularProgressBar.TabIndex = 0;
            this.circularProgressBar.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.circularProgressBar.Value = 68;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(345, 463);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "label1";
            // 
            // EzClean
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EzClean.Properties.Resources.buttonUnpressed1;
            this.ClientSize = new System.Drawing.Size(720, 500);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.circularProgressBar);
            this.Controls.Add(this.labelEzClean);
            this.Controls.Add(this.pictureBoxSettings);
            this.Controls.Add(this.pictureBoxClose);
            this.Controls.Add(this.labelDir);
            this.Controls.Add(this.btnClean);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(720, 500);
            this.MinimumSize = new System.Drawing.Size(720, 500);
            this.Name = "EzClean";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.EzClean_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnClean)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSettings)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btnClean;
        private System.Windows.Forms.Label labelDir;
        private System.Windows.Forms.PictureBox pictureBoxClose;
        private System.Windows.Forms.PictureBox pictureBoxSettings;
        private System.Windows.Forms.Label labelEzClean;
        private CircularProgressBar.CircularProgressBar circularProgressBar;
        private System.Windows.Forms.Label label1;
    }
}

