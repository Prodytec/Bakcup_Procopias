
namespace Cargar_series
{
    partial class Series
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
            this.cbfiltro = new System.Windows.Forms.ComboBox();
            this.dgvfacturas = new System.Windows.Forms.DataGridView();
            this.txtnombrecli = new System.Windows.Forms.TextBox();
            this.txtfecha = new System.Windows.Forms.TextBox();
            this.txttipo = new System.Windows.Forms.TextBox();
            this.txtsucursal = new System.Windows.Forms.TextBox();
            this.txtnumero = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvfacturas)).BeginInit();
            this.SuspendLayout();
            // 
            // cbfiltro
            // 
            this.cbfiltro.FormattingEnabled = true;
            this.cbfiltro.Location = new System.Drawing.Point(12, 12);
            this.cbfiltro.Name = "cbfiltro";
            this.cbfiltro.Size = new System.Drawing.Size(121, 21);
            this.cbfiltro.TabIndex = 0;
            // 
            // dgvfacturas
            // 
            this.dgvfacturas.AllowUserToAddRows = false;
            this.dgvfacturas.AllowUserToDeleteRows = false;
            this.dgvfacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvfacturas.Location = new System.Drawing.Point(12, 111);
            this.dgvfacturas.Name = "dgvfacturas";
            this.dgvfacturas.ReadOnly = true;
            this.dgvfacturas.Size = new System.Drawing.Size(776, 327);
            this.dgvfacturas.TabIndex = 1;
            // 
            // txtnombrecli
            // 
            this.txtnombrecli.Location = new System.Drawing.Point(13, 85);
            this.txtnombrecli.Name = "txtnombrecli";
            this.txtnombrecli.Size = new System.Drawing.Size(178, 20);
            this.txtnombrecli.TabIndex = 2;
            // 
            // txtfecha
            // 
            this.txtfecha.Location = new System.Drawing.Point(197, 85);
            this.txtfecha.Name = "txtfecha";
            this.txtfecha.Size = new System.Drawing.Size(168, 20);
            this.txtfecha.TabIndex = 3;
            // 
            // txttipo
            // 
            this.txttipo.Location = new System.Drawing.Point(371, 85);
            this.txttipo.Name = "txttipo";
            this.txttipo.Size = new System.Drawing.Size(123, 20);
            this.txttipo.TabIndex = 4;
            // 
            // txtsucursal
            // 
            this.txtsucursal.Location = new System.Drawing.Point(500, 85);
            this.txtsucursal.Name = "txtsucursal";
            this.txtsucursal.Size = new System.Drawing.Size(151, 20);
            this.txtsucursal.TabIndex = 5;
            // 
            // txtnumero
            // 
            this.txtnumero.Location = new System.Drawing.Point(657, 85);
            this.txtnumero.Name = "txtnumero";
            this.txtnumero.Size = new System.Drawing.Size(131, 20);
            this.txtnumero.TabIndex = 6;
            // 
            // Series
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtnumero);
            this.Controls.Add(this.txtsucursal);
            this.Controls.Add(this.txttipo);
            this.Controls.Add(this.txtfecha);
            this.Controls.Add(this.txtnombrecli);
            this.Controls.Add(this.dgvfacturas);
            this.Controls.Add(this.cbfiltro);
            this.Name = "Series";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Series";
            this.Load += new System.EventHandler(this.Series_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvfacturas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbfiltro;
        private System.Windows.Forms.DataGridView dgvfacturas;
        private System.Windows.Forms.TextBox txtnombrecli;
        private System.Windows.Forms.TextBox txtfecha;
        private System.Windows.Forms.TextBox txttipo;
        private System.Windows.Forms.TextBox txtsucursal;
        private System.Windows.Forms.TextBox txtnumero;
    }
}