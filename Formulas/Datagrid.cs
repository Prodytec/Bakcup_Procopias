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
        SqlCommand cmd = new SqlCommand();

        public void Llenardatagrid(DataGridView dgv, string Consulta, int Seleccion, MaskedTextBox Desde, MaskedTextBox Hasta, string Campo, TextBox Valor)
        {
            try
            {

                da = new SqlDataAdapter(Consulta, cnn);
                dt = new DataTable();
                dgv.DataSource = dt;
                DataSet ds = new DataSet();

                da.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@Seleccion", Seleccion);
                da.SelectCommand.Parameters.AddWithValue("@Campo", Campo);
                da.SelectCommand.Parameters.AddWithValue("@valor", Valor.Text.ToString());
                da.SelectCommand.Parameters.AddWithValue("@desde", Desde.Text.ToString());
                da.SelectCommand.Parameters.AddWithValue("@hasta", Hasta.Text.ToString());
                da.Fill(ds, "Consulta");
                cnn.Close();


                dgv.DataSource = ds;
                dgv.DataMember = "Consulta";

            }

            catch (Exception ex)
            {
                MessageBox.Show("No se pudo llenar la tabla" + ex.ToString());
            }
        }

        public void Buscargrid(DataGridView dgv, string Consulta, int Seleccion, MaskedTextBox Desde, MaskedTextBox Hasta, string Campo, TextBox Valor)
        {
            try
            {

                da = new SqlDataAdapter(Consulta, cnn);
                dt = new DataTable();
                dgv.DataSource = dt;
                DataSet ds = new DataSet();
                da.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@Seleccion", Seleccion);
                da.SelectCommand.Parameters.AddWithValue("@Campo", Campo);
                da.SelectCommand.Parameters.AddWithValue("@valor", Valor.Text.ToString());
                da.SelectCommand.Parameters.AddWithValue("@Desde", Desde.Text.ToString());
                da.SelectCommand.Parameters.AddWithValue("@Hasta", Hasta.Text.ToString());
                da.Fill(ds, "Consulta");
                cnn.Close();
                dgv.DataSource = ds;
                dgv.DataMember = "Consulta";
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo llenar la tabla" + ex.ToString());
            }
        }
        public void Buscargrid(DataGridView dgv, string Consulta, int Seleccion, MaskedTextBox Desde, MaskedTextBox Hasta, string Campo, MaskedTextBox Valor)
        {
            try
            {
                da = new SqlDataAdapter(Consulta, cnn);
                dt = new DataTable();
                dgv.DataSource = dt;
                DataSet ds = new DataSet();
                da.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@Seleccion", Seleccion);
                da.SelectCommand.Parameters.AddWithValue("@Campo", Campo);
                da.SelectCommand.Parameters.AddWithValue("@valor", Valor.Text.ToString());
                da.SelectCommand.Parameters.AddWithValue("@Desde", Desde.Text.ToString());
                da.SelectCommand.Parameters.AddWithValue("@Hasta", Hasta.Text.ToString());
                da.Fill(ds, "Consulta");
                dgv.DataSource = dt;
                cnn.Close();
                dgv.DataSource = ds;
                dgv.DataMember = "Consulta";
                //dgv.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                //dgv.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                //dgv.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                //dgv.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo llenar la tabla" + ex.ToString());
            }
        }
    }
}
