using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulas
{
    public class Datagrid
    {
        SqlConnection cnn = Conexionbd.DbConnection.getDBConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();
        public void Llenardatagrid(DataGridView dgv, string Consulta)
        {
            try
            {

                da = new SqlDataAdapter(Consulta, cnn);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;

            }

            catch (Exception ex)
            {
                MessageBox.Show("No se pudo llenar la tabla" + ex.ToString());
            }
        }
    }
}
