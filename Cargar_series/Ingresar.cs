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
        public int item;
        string Sql = "SP_SERIES";
        string Valor = "series";

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Ingresar_Load(object sender, EventArgs e)
        {
            Datagrid.Grabar(dgv, Sql,1, Valor, item, idimagen);
        }

        private void btngrabar_Click(object sender, EventArgs e)
        {
            try
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand("delete from SERIESARTICULOS where IDIMAGEN =" + idimagen + "and ITEM =" + item + "", cnn);
                cmd.ExecuteNonQuery();
                cnn.Close();
                for (int fila = 0; fila < dgv.Rows.Count - 1; fila++)
                {
                    for (int col = 0; col < dgv.Rows[fila].Cells.Count; col++)
                    {
                        string valor = dgv.Rows[fila].Cells[col].Value.ToString();
                        Datagrid.Grabar(dgv, Sql, 2, valor, item, idimagen);
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
    }
}
