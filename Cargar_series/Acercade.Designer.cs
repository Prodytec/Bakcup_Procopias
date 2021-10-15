
namespace Cargar_series
{
    partial class Acercade
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
            this.lblversion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblversion
            // 
            this.lblversion.AutoSize = true;
            this.lblversion.Location = new System.Drawing.Point(12, 85);
            this.lblversion.Name = "lblversion";
            this.lblversion.Size = new System.Drawing.Size(0, 13);
            this.lblversion.TabIndex = 0;
            // 
            // Acercade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 107);
            this.Controls.Add(this.lblversion);
            this.Name = "Acercade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Acerca de";
            this.Load += new System.EventHandler(this.Acercade_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblversion;
    }
}