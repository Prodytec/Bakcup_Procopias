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
    public partial class Series : Form
    {
        public Series()
        {
            InitializeComponent();
        }
        Datagrid Datagrid = new Datagrid();
        private void Series_Load(object sender, EventArgs e)
        {
            cbfiltro.Items.Add("Mes actual");
            cbfiltro.Items.Add("Hoy");
            cbfiltro.Items.Add("Personalizado");
            cbfiltro.SelectedItem = cbfiltro.Items[0];

            //nombre del store para llenar el datagrid
            string store = "sp_Ecommercebrm";

            Datagrid.Llenardatagrid(dgvfacturas, store);
        }

        private void cbfiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbfiltro.SelectedIndex == 0 || cbfiltro.SelectedIndex == 1)
            {
                lbldesde.Visible = false;
                lblhasta.Visible = false;
                txtdesde.Visible = false;
                txthasta.Visible = false;
            }
            else
            {
                lbldesde.Visible = true;
                lblhasta.Visible = true;
                txtdesde.Visible = true;
                txthasta.Visible = true;
            }
        }
    }
}
