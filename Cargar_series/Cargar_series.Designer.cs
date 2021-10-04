
namespace Cargar_series
{
    partial class Cargar_series
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvfacturas = new System.Windows.Forms.DataGridView();
            this.lblcliente = new System.Windows.Forms.Label();
            this.lblfactura = new System.Windows.Forms.Label();
            this.lblfecha = new System.Windows.Forms.Label();
            this.txtcliente = new System.Windows.Forms.TextBox();
            this.txtfactura = new System.Windows.Forms.TextBox();
            this.txtfecha = new System.Windows.Forms.TextBox();
            this.btnsalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvfacturas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvfacturas
            // 
            this.dgvfacturas.AllowUserToAddRows = false;
            this.dgvfacturas.AllowUserToDeleteRows = false;
            this.dgvfacturas.AllowUserToOrderColumns = true;
            this.dgvfacturas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvfacturas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvfacturas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvfacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvfacturas.Location = new System.Drawing.Point(12, 111);
            this.dgvfacturas.Name = "dgvfacturas";
            this.dgvfacturas.ReadOnly = true;
            this.dgvfacturas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvfacturas.Size = new System.Drawing.Size(776, 301);
            this.dgvfacturas.TabIndex = 5;
            this.dgvfacturas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvfacturas_CellClick);
            // 
            // lblcliente
            // 
            this.lblcliente.AutoSize = true;
            this.lblcliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.lblcliente.Location = new System.Drawing.Point(13, 13);
            this.lblcliente.Name = "lblcliente";
            this.lblcliente.Size = new System.Drawing.Size(70, 20);
            this.lblcliente.TabIndex = 6;
            this.lblcliente.Text = "Cliente:";
            // 
            // lblfactura
            // 
            this.lblfactura.AutoSize = true;
            this.lblfactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.lblfactura.Location = new System.Drawing.Point(13, 44);
            this.lblfactura.Name = "lblfactura";
            this.lblfactura.Size = new System.Drawing.Size(76, 20);
            this.lblfactura.TabIndex = 7;
            this.lblfactura.Text = "Factura:";
            // 
            // lblfecha
            // 
            this.lblfecha.AutoSize = true;
            this.lblfecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.lblfecha.Location = new System.Drawing.Point(318, 44);
            this.lblfecha.Name = "lblfecha";
            this.lblfecha.Size = new System.Drawing.Size(64, 20);
            this.lblfecha.TabIndex = 8;
            this.lblfecha.Text = "Fecha:";
            // 
            // txtcliente
            // 
            this.txtcliente.Enabled = false;
            this.txtcliente.Location = new System.Drawing.Point(90, 12);
            this.txtcliente.Name = "txtcliente";
            this.txtcliente.Size = new System.Drawing.Size(210, 20);
            this.txtcliente.TabIndex = 9;
            // 
            // txtfactura
            // 
            this.txtfactura.Enabled = false;
            this.txtfactura.Location = new System.Drawing.Point(90, 44);
            this.txtfactura.Name = "txtfactura";
            this.txtfactura.Size = new System.Drawing.Size(210, 20);
            this.txtfactura.TabIndex = 10;
            // 
            // txtfecha
            // 
            this.txtfecha.Enabled = false;
            this.txtfecha.Location = new System.Drawing.Point(388, 44);
            this.txtfecha.MaxLength = 6;
            this.txtfecha.Name = "txtfecha";
            this.txtfecha.Size = new System.Drawing.Size(103, 20);
            this.txtfecha.TabIndex = 11;
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(704, 418);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(84, 23);
            this.btnsalir.TabIndex = 12;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // Cargar_series
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.txtfecha);
            this.Controls.Add(this.txtfactura);
            this.Controls.Add(this.txtcliente);
            this.Controls.Add(this.lblfecha);
            this.Controls.Add(this.lblfactura);
            this.Controls.Add(this.lblcliente);
            this.Controls.Add(this.dgvfacturas);
            this.Name = "Cargar_series";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cargar series";
            this.Load += new System.EventHandler(this.Cargar_series_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvfacturas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvfacturas;
        public System.Windows.Forms.Label lblcliente;
        public System.Windows.Forms.Label lblfactura;
        public System.Windows.Forms.Label lblfecha;
        public System.Windows.Forms.TextBox txtcliente;
        public System.Windows.Forms.TextBox txtfactura;
        public System.Windows.Forms.TextBox txtfecha;
        private System.Windows.Forms.Button btnsalir;
    }
}