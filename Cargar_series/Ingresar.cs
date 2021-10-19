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
                        if (this.dgv.Rows[fila].Cells[col].Value.ToString() != null)
                        {
                            string valor = this.dgv.Rows[fila].Cells[col].Value.ToString();
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
            if (this.dgv.Rows.Count - 1 == cantidad)
            {
                this.dgv.AllowUserToAddRows = false;
                MessageBox.Show("No se pueden cargar mas series");
            }
        }
    }
}
