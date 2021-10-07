using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Formulas;

namespace Cargar_series
{
    public partial class Exportar_excel : Form
    {
        public Exportar_excel()
        {
            InitializeComponent();
        }

        Datagrid D = new Datagrid();

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Procesar_Click(object sender, EventArgs e)
        {
            D.Cargarexcel(txtdesdef, txthastaf, dataGridView1, txtdesdep, txthastap);
        }

        private void btnexportar_Click(object sender, EventArgs e)
        {
            D.ExportarDataGridViewExcel(dataGridView1);
        }
    }
}
