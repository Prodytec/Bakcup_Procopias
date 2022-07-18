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
        Herramientas H = new Herramientas();

        private void Series_Load(object sender, EventArgs e)
        {
            cbfiltro.Items.Add("Seleccione una opcion");
            cbfiltro.Items.Add("Facturas");
            cbfiltro.Items.Add("Remitos");
            cbfiltro.Items.Add("Remitos Servicios");
            cbfiltro.SelectedItem = cbfiltro.Items[0];

        }

        string Facturas = "SP_FACTURAS_PROCOPIAS";
        string Remitos = "SP_REMITOS_PROCOPIAS";
        string RemitosServicios = "SP_REMITOS_SERVICIOS_PROCOPIAS";
        string Nombrecli = "Cli.Nombre";
        string Tipo = "tipo.NombreCorto";
        string Sucursal = "Imag.Sucursal";
        string sucursalR = "remito.sucursal";
        string Numero = "Imag.Numero";
        string NumeroR = "remito.Numero";
        string Fecha = "Imag.Fecha";

        private void txtnombrecli_KeyUp(object sender, KeyEventArgs e)
        {
            if(cbfiltro.SelectedIndex == 1)
            {
                Datagrid.Llenardatagrid(dgvfacturas, Facturas, 4, Nombrecli, txtnombrecli);
            }
            else if(cbfiltro.SelectedIndex == 2)
            {
                Datagrid.Llenardatagrid(dgvfacturas, Remitos, 2, Nombrecli, txtnombrecli);
            }
            else if(cbfiltro.SelectedIndex == 3)
            {
                Datagrid.Llenardatagrid(dgvfacturas, RemitosServicios, 2, Nombrecli, txtnombrecli);
            }
            
        }

        private void txttipo_KeyUp(object sender, KeyEventArgs e)
        {
            if(cbfiltro.SelectedIndex == 1)
            {
                Datagrid.Llenardatagrid(dgvfacturas, Facturas, 4, Tipo, txttipo);
            }
            else if(cbfiltro.SelectedIndex == 2)
            {
                Datagrid.Llenardatagrid(dgvfacturas, Remitos, 2, Tipo, txttipo);
            }
            else if (cbfiltro.SelectedIndex == 3)
            {
                Datagrid.Llenardatagrid(dgvfacturas, RemitosServicios, 2, Tipo, txttipo);
            }
        }

        private void txtsucursal_KeyUp(object sender, KeyEventArgs e)
        {
            if(cbfiltro.SelectedIndex == 1)
            {
                Datagrid.Llenardatagrid(dgvfacturas, Facturas, 4, Sucursal, txtsucursal);
            }
            else if(cbfiltro.SelectedIndex == 2)
            {
                Datagrid.Llenardatagrid(dgvfacturas, Remitos, 2, sucursalR, txtsucursal);
            }
            else if(cbfiltro.SelectedIndex == 3)
            {
                Datagrid.Llenardatagrid(dgvfacturas, RemitosServicios, 2, sucursalR, txtsucursal);
            }
        }

        private void txtnumero_KeyUp(object sender, KeyEventArgs e)
        {
            if(cbfiltro.SelectedIndex == 1)
            {
                Datagrid.Llenardatagrid(dgvfacturas, Facturas, 4, Numero, txtnumero);
            }
            else if(cbfiltro.SelectedIndex == 2)
            {
                Datagrid.Llenardatagrid(dgvfacturas, Remitos, 2, NumeroR, txtnumero);
            }
            else if (cbfiltro.SelectedIndex == 3)
            {
                Datagrid.Llenardatagrid(dgvfacturas, RemitosServicios, 2, NumeroR, txtnumero);
            }
        }

        private void mtxtbuscarfecha_TextChanged(object sender, EventArgs e)
        {
            if(cbfiltro.SelectedIndex == 1)
            {
                Datagrid.Buscargrid(dgvfacturas, Facturas, 5, Fecha, mtxtbuscarfecha);
            }
            else if(cbfiltro.SelectedIndex == 2)
            {
                Datagrid.Buscargrid(dgvfacturas, Remitos, 3, Fecha, mtxtbuscarfecha);
            }
            else if (cbfiltro.SelectedIndex == 3)
            {
                Datagrid.Buscargrid(dgvfacturas, RemitosServicios, 3, Fecha, mtxtbuscarfecha);
            }
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvfacturas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(cbfiltro.SelectedIndex == 1)
            {
                if (e.RowIndex >= 0)
                {
                    Cargar_series C = new Cargar_series();
                    C.txtcliente.Text = dgvfacturas.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
                    C.txtfactura.Text = dgvfacturas.Rows[e.RowIndex].Cells["Sucursal"].Value.ToString() + "-" + dgvfacturas.Rows[e.RowIndex].Cells["Numero"].Value.ToString();
                    C.txtfecha.Text = dgvfacturas.Rows[e.RowIndex].Cells["Fecha"].Value.ToString();
                    C.idimagen = Convert.ToInt32(dgvfacturas.Rows[e.RowIndex].Cells["idimagen"].Value.ToString());
                    C.Tipo = dgvfacturas.Rows[e.RowIndex].Cells["Tipo"].Value.ToString();
                    C.ShowDialog();
                }
            }
            else if (cbfiltro.SelectedIndex == 2)
            {
                if (e.RowIndex >= 0)
                {
                    Cargar_series C = new Cargar_series();
                    C.txtcliente.Text = dgvfacturas.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
                    C.txtfactura.Text = dgvfacturas.Rows[e.RowIndex].Cells["Sucursal"].Value.ToString() + "-" + dgvfacturas.Rows[e.RowIndex].Cells["Numero"].Value.ToString();
                    C.txtfecha.Text = dgvfacturas.Rows[e.RowIndex].Cells["Fecha"].Value.ToString();
                    C.idinterno = Convert.ToInt32(dgvfacturas.Rows[e.RowIndex].Cells["IdInterno"].Value.ToString());
                    C.Tipo = dgvfacturas.Rows[e.RowIndex].Cells["Tipo"].Value.ToString();
                    C.ShowDialog();
                }
            }
            else if(cbfiltro.SelectedIndex == 3)
            {
                if (e.RowIndex >= 0)
                {
                    Cargar_series C = new Cargar_series();
                    C.txtcliente.Text = dgvfacturas.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
                    C.txtfactura.Text = dgvfacturas.Rows[e.RowIndex].Cells["Sucursal"].Value.ToString() + "-" + dgvfacturas.Rows[e.RowIndex].Cells["Numero"].Value.ToString();
                    C.txtfecha.Text = dgvfacturas.Rows[e.RowIndex].Cells["Fecha"].Value.ToString();
                    C.idinterno = Convert.ToInt32(dgvfacturas.Rows[e.RowIndex].Cells["IdInterno"].Value.ToString());
                    C.Tipo = dgvfacturas.Rows[e.RowIndex].Cells["Tipo"].Value.ToString();
                    C.ShowDialog();
                }
            }
                
        }

        private void cbfiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbfiltro.SelectedIndex == 1)
            {
                //H.LimpiarGrid(dgvfacturas);
                Datagrid.Llenardatagrid(dgvfacturas, Facturas, 2, Nombrecli, txtnombrecli);
            }
            else if(cbfiltro.SelectedIndex == 2)
            {
                //H.LimpiarGrid(dgvfacturas);
                Datagrid.Llenardatagrid(dgvfacturas, Remitos, 1, Nombrecli, txtnombrecli);
            }
            else if(cbfiltro.SelectedIndex == 3)
            {
                H.LimpiarGrid(dgvfacturas);
                Datagrid.Llenardatagrid(dgvfacturas, RemitosServicios, 1, Nombrecli, txtnombrecli);
            }
        }
    }
}
