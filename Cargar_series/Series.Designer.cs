
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
            this.lbldesde = new System.Windows.Forms.Label();
            this.lblhasta = new System.Windows.Forms.Label();
            this.txtdesde = new System.Windows.Forms.TextBox();
            this.txthasta = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvfacturas)).BeginInit();
            this.SuspendLayout();
            // 
            // cbfiltro
            // 
            this.cbfiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbfiltro.FormattingEnabled = true;
            this.cbfiltro.Location = new System.Drawing.Point(12, 12);
            this.cbfiltro.Name = "cbfiltro";
            this.cbfiltro.Size = new System.Drawing.Size(121, 21);
            this.cbfiltro.TabIndex = 0;
            this.cbfiltro.SelectedIndexChanged += new System.EventHandler(this.cbfiltro_SelectedIndexChanged);
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
            // lbldesde
            // 
            this.lbldesde.AutoSize = true;
            this.lbldesde.Location = new System.Drawing.Point(159, 16);
            this.lbldesde.Name = "lbldesde";
            this.lbldesde.Size = new System.Drawing.Size(69, 13);
            this.lbldesde.TabIndex = 7;
            this.lbldesde.Text = "Fecha desde";
            // 
            // lblhasta
            // 
            this.lblhasta.AutoSize = true;
            this.lblhasta.Location = new System.Drawing.Point(416, 16);
            this.lblhasta.Name = "lblhasta";
            this.lblhasta.Size = new System.Drawing.Size(35, 13);
            this.lblhasta.TabIndex = 8;
            this.lblhasta.Text = "Hasta";
            // 
            // txtdesde
            // 
            this.txtdesde.Location = new System.Drawing.Point(243, 13);
            this.txtdesde.Name = "txtdesde";
            this.txtdesde.Size = new System.Drawing.Size(142, 20);
            this.txtdesde.TabIndex = 9;
            // 
            // txthasta
            // 
            this.txthasta.Location = new System.Drawing.Point(478, 13);
            this.txthasta.Name = "txthasta";
            this.txthasta.Size = new System.Drawing.Size(156, 20);
            this.txthasta.TabIndex = 10;
            // 
            // Series
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txthasta);
            this.Controls.Add(this.txtdesde);
            this.Controls.Add(this.lblhasta);
            this.Controls.Add(this.lbldesde);
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
        private System.Windows.Forms.Label lbldesde;
        private System.Windows.Forms.Label lblhasta;
        private System.Windows.Forms.TextBox txtdesde;
        private System.Windows.Forms.TextBox txthasta;
    }
}