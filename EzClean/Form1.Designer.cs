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
            ((System.ComponentModel.ISupportInitialize)(this.btnClean)).BeginInit();
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
            // EzClean
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EzClean.Properties.Resources.buttonUnpressed;
            this.ClientSize = new System.Drawing.Size(720, 500);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btnClean;
        private System.Windows.Forms.Label labelDir;
    }
}

