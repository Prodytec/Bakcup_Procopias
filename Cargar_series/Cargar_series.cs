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
        

        private void Cargar_series_Load(object sender, EventArgs e)
        {
            string texto = txtfactura.Text;
            string Fecha = txtfecha.Text;
            char [] separador = { '-' , ' '};
            string[] palabra = texto.Split(separador);
            string[] fech = Fecha.Split(separador);
            string Sucursal = txtfactura.Text = palabra[0];
            string Numero = txtfactura.Text = palabra[1];
            string Fecha1 = txtfecha.Text = fech[0];
            Datagrid.Llenardatagrid(dgvfacturas, Consulta, Sucursal, Numero, Fecha1);
            txtfactura.Text = Sucursal + "-" + Numero;
        }

        private void dgvfacturas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3) 
            {
                I.ShowDialog();
            }
        }
    }
}
