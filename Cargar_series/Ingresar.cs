using Formulas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cargar_series
{
    public partial class Ingresar : Form
    {
        public Ingresar()
        {
            InitializeComponent();
        }

        Datagrid Datagrid = new Datagrid();
        
        string Sql = "SP_SERIES";

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Ingresar_Load(object sender, EventArgs e)
        {
            string serie = dgv.CurrentCell.Value.ToString();
            Datagrid.Llenardatagrid(dgv, Sql, 1, serie);
                
        }

        private void btngrabar_Click(object sender, EventArgs e)
        {
            string serie = dgv.CurrentCell.Value.ToString();
            Datagrid.Llenardatagrid(dgv, Sql, 2, serie);
        }
    }
}
