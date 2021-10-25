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
            cbfiltro.Visible = false;

        }

        string Todos = "SP_FACTURAS_PROCOPIAS";
        string Nombrecli = "Cli.Nombre";
        string Tipo = "tipo.NombreCorto";
        string Sucursal = "Imag.Sucursal";
        string Numero = "Imag.Numero";
        string Fecha = "Imag.Fecha";

        private void cbfiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbfiltro.SelectedIndex == 0 )
            {
                lbldesde.Visible = false;
                lblhasta.Visible = false;
                mtxtdesde.Visible = false;
                mtxthasta.Visible = false;
                Datagrid.Llenardatagrid(dgvfacturas, Todos, 1, mtxtdesde, mtxthasta, Nombrecli, txtnombrecli);
                
            }
            else if(cbfiltro.SelectedIndex == 1)
            {
                lbldesde.Visible = false;
                lblhasta.Visible = false;
                mtxtdesde.Visible = false;
                mtxthasta.Visible = false;
                Datagrid.Llenardatagrid(dgvfacturas, Todos, 2, mtxtdesde, mtxthasta, Nombrecli, txtnombrecli); ;
            }
            else
            {
                lbldesde.Visible = true;
                lblhasta.Visible = true;
                mtxtdesde.Visible = true;
                mtxthasta.Visible = true;
            }
        }

        private void txtnombrecli_KeyUp(object sender, KeyEventArgs e)
        {
            Datagrid.Llenardatagrid(dgvfacturas, Todos, 4, mtxtdesde, mtxthasta, Nombrecli, txtnombrecli);
        }

        private void mtxthasta_Leave(object sender, EventArgs e)
        {
            Datagrid.Llenardatagrid(dgvfacturas, Todos, 3, mtxtdesde, mtxthasta, Nombrecli, txtnombrecli);
        }

        private void txttipo_KeyUp(object sender, KeyEventArgs e)
        {
            Datagrid.Llenardatagrid(dgvfacturas, Todos, 4, mtxtdesde, mtxthasta, Tipo, txttipo);
        }

        private void txtsucursal_KeyUp(object sender, KeyEventArgs e)
        {
            Datagrid.Llenardatagrid(dgvfacturas, Todos, 4, mtxtdesde, mtxthasta, Sucursal, txtsucursal);
        }

        private void txtnumero_KeyUp(object sender, KeyEventArgs e)
        {
            Datagrid.Llenardatagrid(dgvfacturas, Todos, 4, mtxtdesde, mtxthasta, Numero, txtnumero);
        }

        private void mtxtbuscarfecha_TextChanged(object sender, EventArgs e)
        {
            Datagrid.Buscargrid(dgvfacturas, Todos, 5, mtxtdesde, mtxthasta, Fecha, mtxtbuscarfecha);
        }

        private void dgvfacturas_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            
            
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvfacturas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Cargar_series C = new Cargar_series();
                C.txtcliente.Text = dgvfacturas.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
                C.txtfactura.Text = dgvfacturas.Rows[e.RowIndex].Cells["Sucursal"].Value.ToString() + "-" + dgvfacturas.Rows[e.RowIndex].Cells["Numero"].Value.ToString();
                C.txtfecha.Text = dgvfacturas.Rows[e.RowIndex].Cells["Fecha"].Value.ToString();
                C.idimagen = Convert.ToInt32(dgvfacturas.Rows[e.RowIndex].Cells["idimagen"].Value.ToString());
                C.ShowDialog();
            }
        }
    }
}
