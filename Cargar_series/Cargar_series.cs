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
    public partial class Cargar_series : Form
    {
        public Cargar_series()
        {
            InitializeComponent();
        }

        Datagrid Datagrid = new Datagrid();
        Ingresar I = new Ingresar();
        string Consulta = "ITEMS_SERIES_PROCOPIAS";
        string CItemRemito = "ITEMS_SERIES_PROCOPIAS_REMITOS";
        string CitemRemitoServicios = "ITEMS_SERIES_PROCOPIAS_REMITOS_SERVICIOS";
        public int idimagen;
        public int idinterno;
        public string Tipo;
        

        private void Cargar_series_Load(object sender, EventArgs e)
        {
            if(Tipo == "RM")
            {
                string texto = txtfactura.Text;
                string Fecha = txtfecha.Text;
                char[] separador = { '-', ' ' };
                string[] palabra = texto.Split(separador);
                string[] fech = Fecha.Split(separador);
                string Sucursal = txtfactura.Text = palabra[0];
                string Numero = txtfactura.Text = palabra[1];
                string Fecha1 = txtfecha.Text = fech[0];
                Datagrid.Llenardatagrid(dgvfacturas, CItemRemito, idinterno);
                txtfactura.Text = "RM" + "-" + Sucursal + "-" + Numero;
            }
            else if(Tipo == "RMS")
            {
                string texto = txtfactura.Text;
                string Fecha = txtfecha.Text;
                char[] separador = { '-', ' ' };
                string[] palabra = texto.Split(separador);
                string[] fech = Fecha.Split(separador);
                string Sucursal = txtfactura.Text = palabra[0];
                string Numero = txtfactura.Text = palabra[1];
                string Fecha1 = txtfecha.Text = fech[0];
                Datagrid.Llenardatagrid(dgvfacturas, CitemRemitoServicios, idinterno);
                txtfactura.Text = "RMS" + "-" + Sucursal + "-" + Numero;
            }
            else
            {
                string texto = txtfactura.Text;
                string Fecha = txtfecha.Text;
                char[] separador = { '-', ' ' };
                string[] palabra = texto.Split(separador);
                string[] fech = Fecha.Split(separador);
                string Sucursal = txtfactura.Text = palabra[0];
                string Numero = txtfactura.Text = palabra[1];
                string Fecha1 = txtfecha.Text = fech[0];
                Datagrid.Llenardatagrid(dgvfacturas, Consulta, idimagen);
                txtfactura.Text = "FAC" + "-" + Sucursal + "-" + Numero;
            }
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvfacturas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                if(e.RowIndex == -1)
                {

                }
                else
                {
                    I.idimagen = idimagen;
                    I.codigoart = dgvfacturas.Rows[e.RowIndex].Cells["Codigo"].Value.ToString();
                    I.cantidad = Convert.ToInt32(dgvfacturas.Rows[e.RowIndex].Cells["Cantidad pedida"].Value.ToString());
                    if (dgvfacturas.Rows[e.RowIndex].Cells["Cantidad pedida"].Value.ToString() == dgvfacturas.Rows[e.RowIndex].Cells["Cantidad escaneada"].Value.ToString())
                    {
                        I.dgv.AllowUserToAddRows = false;
                        I.ShowDialog();
                        dgvfacturas.DataSource = null;
                        dgvfacturas.Rows.Clear();
                        Datagrid.Llenardatagrid(dgvfacturas, Consulta, idimagen);
                    }
                    else
                    {
                        I.ShowDialog();
                        dgvfacturas.DataSource = null;
                        dgvfacturas.Rows.Clear();
                        dgvfacturas.Columns.Clear();
                        Datagrid.Llenardatagrid(dgvfacturas, Consulta, idimagen);
                    }
                }
            }
        }

        private void btnreporte_Click(object sender, EventArgs e)
        {
            Reportepdf pdf = new Reportepdf();
            pdf.idimagen = idimagen;
            pdf.nombrecli = txtcliente.Text;
            pdf.numerofc = txtfactura.Text;
            pdf.fecha = txtfecha.Text;
            pdf.ShowDialog();
        }
    }
}
