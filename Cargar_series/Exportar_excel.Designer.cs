
namespace Cargar_series
{
    partial class Exportar_excel
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Procesar = new System.Windows.Forms.Button();
            this.lbldesde = new System.Windows.Forms.Label();
            this.lblhasta = new System.Windows.Forms.Label();
            this.txtdesdep = new System.Windows.Forms.TextBox();
            this.btnsalir = new System.Windows.Forms.Button();
            this.txthastap = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtdesdef = new System.Windows.Forms.MaskedTextBox();
            this.txthastaf = new System.Windows.Forms.MaskedTextBox();
            this.btnexportar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 105);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(775, 304);
            this.dataGridView1.TabIndex = 6;
            // 
            // Procesar
            // 
            this.Procesar.Location = new System.Drawing.Point(701, 43);
            this.Procesar.Name = "Procesar";
            this.Procesar.Size = new System.Drawing.Size(87, 23);
            this.Procesar.TabIndex = 5;
            this.Procesar.Text = "Procesar";
            this.Procesar.UseVisualStyleBackColor = true;
            this.Procesar.Click += new System.EventHandler(this.Procesar_Click);
            // 
            // lbldesde
            // 
            this.lbldesde.AutoSize = true;
            this.lbldesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldesde.Location = new System.Drawing.Point(13, 43);
            this.lbldesde.Name = "lbldesde";
            this.lbldesde.Size = new System.Drawing.Size(66, 20);
            this.lbldesde.TabIndex = 2;
            this.lbldesde.Text = "Desde:";
            // 
            // lblhasta
            // 
            this.lblhasta.AutoSize = true;
            this.lblhasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhasta.Location = new System.Drawing.Point(13, 79);
            this.lblhasta.Name = "lblhasta";
            this.lblhasta.Size = new System.Drawing.Size(62, 20);
            this.lblhasta.TabIndex = 3;
            this.lblhasta.Text = "Hasta:";
            // 
            // txtdesdep
            // 
            this.txtdesdep.Location = new System.Drawing.Point(86, 42);
            this.txtdesdep.Name = "txtdesdep";
            this.txtdesdep.Size = new System.Drawing.Size(100, 20);
            this.txtdesdep.TabIndex = 1;
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(701, 415);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(87, 23);
            this.btnsalir.TabIndex = 7;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // txthastap
            // 
            this.txthastap.Location = new System.Drawing.Point(85, 79);
            this.txthastap.Name = "txthastap";
            this.txthastap.Size = new System.Drawing.Size(100, 20);
            this.txthastap.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Proveedores";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(280, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Fecha de facturacion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(280, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Hasta:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(280, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Desde:";
            // 
            // txtdesdef
            // 
            this.txtdesdef.Location = new System.Drawing.Point(352, 43);
            this.txtdesdef.Mask = "00/00/0000";
            this.txtdesdef.Name = "txtdesdef";
            this.txtdesdef.Size = new System.Drawing.Size(107, 20);
            this.txtdesdef.TabIndex = 13;
            this.txtdesdef.ValidatingType = typeof(System.DateTime);
            // 
            // txthastaf
            // 
            this.txthastaf.Location = new System.Drawing.Point(352, 78);
            this.txthastaf.Mask = "00/00/0000";
            this.txthastaf.Name = "txthastaf";
            this.txthastaf.Size = new System.Drawing.Size(107, 20);
            this.txthastaf.TabIndex = 14;
            this.txthastaf.ValidatingType = typeof(System.DateTime);
            // 
            // btnexportar
            // 
            this.btnexportar.Location = new System.Drawing.Point(701, 75);
            this.btnexportar.Name = "btnexportar";
            this.btnexportar.Size = new System.Drawing.Size(87, 23);
            this.btnexportar.TabIndex = 15;
            this.btnexportar.Text = "Exportar";
            this.btnexportar.UseVisualStyleBackColor = true;
            this.btnexportar.Click += new System.EventHandler(this.btnexportar_Click);
            // 
            // Exportar_excel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnexportar);
            this.Controls.Add(this.txthastaf);
            this.Controls.Add(this.txtdesdef);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txthastap);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.txtdesdep);
            this.Controls.Add(this.lblhasta);
            this.Controls.Add(this.lbldesde);
            this.Controls.Add(this.Procesar);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Exportar_excel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exportar_excel";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Procesar;
        private System.Windows.Forms.Label lbldesde;
        private System.Windows.Forms.Label lblhasta;
        private System.Windows.Forms.TextBox txtdesdep;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.TextBox txthastap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox txtdesdef;
        private System.Windows.Forms.MaskedTextBox txthastaf;
        private System.Windows.Forms.Button btnexportar;
    }
}