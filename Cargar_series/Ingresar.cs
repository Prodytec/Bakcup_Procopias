using Formulas;
using Cargar_series;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Cargar_series
{
    public partial class Ingresar : Form
    {
        public Ingresar()
        {
            InitializeComponent();
        }
        
        SqlConnection cnn = Conexionbd.DbConnection.getDBConnection();
        Datagrid Datagrid = new Datagrid();
        public int idimagen;
        public int cantidad;
        public string codigoart;
        string Sql = "SP_SERIES";
        string Valor = "series";


        private void btnsalir_Click(object sender, EventArgs e)
        {
            dgv.AllowUserToAddRows = true;
            this.Close();
        }

        private void Ingresar_Load(object sender, EventArgs e)
        {
            Datagrid.Grabar(dgv, Sql,1, Valor, codigoart, idimagen);
            lblcantpedida.Text = cantidad.ToString();
            int cantidadescan = (dgv.Rows.Count - 1);
            lblcantescan.Text = cantidadescan.ToString();
            dgv.AllowUserToAddRows = true;
            
        }

        private void btngrabar_Click(object sender, EventArgs e)
        {
            try
            {
                this.dgv.AllowUserToAddRows = false;
                cnn.Open();
                SqlCommand cmd = new SqlCommand("delete from SERIESARTICULOS where IDIMAGEN = " + idimagen + "and CODIGOART = " + "'" + codigoart + "'" + "", cnn);
                cmd.ExecuteNonQuery();
                cnn.Close();
                for (int fila = 0; fila < dgv.Rows.Count; fila++)
                {
                    for (int col = 0; col < dgv.Rows[fila].Cells.Count; col++)
                    {
                        string valor = this.dgv.Rows[fila].Cells[col].Value.ToString();
                        if (valor != null)
                        {
                            Datagrid.Grabar(dgv, Sql, 2, valor, codigoart, idimagen);
                        }
                    }
                }
                MessageBox.Show("Se completo la grabacion correctamente");
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("No se pudo completar la grabacion correctamente:" + ex.ToString());
            }
            
        }
       
        private void dgv_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            int filaescrita = 0;
            int filavacia = 0;
            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (row.Cells[0].Value == null || row.Cells[0].Value == DBNull.Value || String.IsNullOrWhiteSpace(row.Cells[0].Value.ToString()))
                {
                    filavacia = filavacia + 1;
                }
                filaescrita = filaescrita + 1;
            }

            int filas = filaescrita - filavacia;
            lblcantescan.Text = Convert.ToString(filas);
            if (this.dgv.Rows.Count - 1 == cantidad)
            {
                this.dgv.AllowUserToAddRows = false;
                MessageBox.Show("No se pueden cargar mas series");
            }
            if(this.dgv.AllowUserToAddRows == false)
            {
                lblcantescan.Text = Convert.ToString(filas);
            }
        }

        private void dgv_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in dgv.Rows)
            {
                String cellText = Convert.ToString(row.Cells[0].Value);

                Datagrid.reccorergrilla(row.Index, cellText, dgv);
            }
        }

        private void dgv_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int filaescrita = 0;
            int filavacia = 0;
            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (row.Cells[0].Value == null || row.Cells[0].Value == DBNull.Value || String.IsNullOrWhiteSpace(row.Cells[0].Value.ToString()))
                {
                    filavacia = filavacia + 1;
                }
                filaescrita = filaescrita + 1;
            }

            int filas = filaescrita - filavacia;
            lblcantescan.Text = Convert.ToString(filas);
        }
    }
}
