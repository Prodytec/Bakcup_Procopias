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

        public void Llenardatagrid(DataGridView dgv, string Consulta, MaskedTextBox Desde, MaskedTextBox Hasta)
        {
            try
            {

                da = new SqlDataAdapter(Consulta, cnn);
                dt = new DataTable();
                dgv.DataSource = dt;
                DataSet ds = new DataSet();

                da.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
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

        public void Buscargrid(DataGridView dgv, TextBox txtbox, string nombre)
        {
            string consulta = "select Cli.nombre as Nombre ,Imag.Fecha as Fecha, Imag.Idtipocomprobante as Tipo, Imag.Sucursal as Sucursal, Imag.Numero as Numero from ImagenFcCab as Imag left join Clientes as Cli on Imag.Idcliente = Cli.idcliente where " + "" + nombre.Trim() + "" + " like('" + txtbox.Text.Trim() + "%')";
            try
            {
                cnn.Open();
                cmd = new SqlCommand(consulta, cnn);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dgv.DataSource = dt;
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo llenar la tabla" + ex.ToString());
            }
        }
        public void Buscargridfecha(DataGridView dgv, MaskedTextBox txtbox)
        {
            string consulta = "select Cli.nombre as Nombre ,Imag.Fecha as Fecha, Imag.Idtipocomprobante as Tipo, Imag.Sucursal as Sucursal, Imag.Numero as Numero from ImagenFcCab as Imag left join Clientes as Cli on Imag.Idcliente = Cli.idcliente where Imag.Fecha like('" + txtbox.Text + "%')";
            try
            {
                cnn.Open();
                cmd = new SqlCommand(consulta, cnn);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dgv.DataSource = dt;
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo llenar la tabla" + ex.ToString());
            }
        }
    }
}
