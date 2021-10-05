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
                dgv.DataSource = dt;
                da.Fill(ds, "Consulta");
                cnn.Close();


                dgv.DataSource = ds;
                dgv.DataMember = "Consulta";

                dgv.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgv.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgv.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgv.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgv.Columns[5].Visible = false;
            }

            catch (Exception ex)
            {
                MessageBox.Show("No se pudo llenar la tabla" + ex.ToString());
            }
        }

        public void Grabar(DataGridView dgv, string Consulta, int Seleccion, string serie, int item, int idimagen)
        {
            try
            {

                if(Seleccion == 1)
                {

                    da = new SqlDataAdapter(Consulta, cnn);
                    dt = new DataTable();
                   
                    
                    //dgv.DataSource = dt;
                    DataSet ds = new DataSet();

                    da.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.AddWithValue("@Seleccion", Seleccion);
                    da.SelectCommand.Parameters.AddWithValue("@serie", serie);
                    da.SelectCommand.Parameters.AddWithValue("@item", item);
                    da.SelectCommand.Parameters.AddWithValue("@idimagenc", idimagen);

                    //dgv.DataSource = dt;
                    da.Fill(ds, "Sp_series");
                    dgv.DataSource = ds;
                    dgv.DataMember = "Sp_Series";
                    //cnn.Close();
                }
                else
                {
                    // connection();  
                    cnn.Open();
                    string query = "sp_series";         //Stored Procedure name   
                    SqlCommand com = new SqlCommand(query, cnn);  //creating  SqlCommand  object  
                    com.CommandType = CommandType.StoredProcedure;  //here we declaring command type as stored Procedure  

                    com.Parameters.AddWithValue("@Seleccion", Seleccion);        //first Name  
                    com.Parameters.AddWithValue("@Serie ", serie);     //middle Name  
                    com.Parameters.AddWithValue("@Item ", item);
                    com.Parameters.AddWithValue("@idimagenc ", idimagen);//Last Name
                                                                         //
                    com.ExecuteNonQuery();                     //executing the sqlcommand  
                    cnn.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puede correr el script" + ex.ToString());
            }
        }


        public void Llenardatagrid(DataGridView dgv, string Consulta, string Sucursal, string Numero, string Fecha)
        {
            try
            {

                da = new SqlDataAdapter(Consulta, cnn);
                dt = new DataTable();
                dgv.DataSource = dt;
                DataSet ds = new DataSet();

                da.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@sucursal", Sucursal);
                da.SelectCommand.Parameters.AddWithValue("@numero", Numero);
                da.SelectCommand.Parameters.AddWithValue("@fecha", Fecha);
                dgv.DataSource = dt;
                da.Fill(ds, "Consulta");
                cnn.Close();

                dgv.DataSource = ds;
                dgv.DataMember = "Consulta";
                DataGridViewButtonColumn btngrid = new DataGridViewButtonColumn();
                btngrid.Name = "Boton";
                btngrid.HeaderText = "Ingresar series";
                dgv.Columns.Add(btngrid);

                dgv.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                dgv.Columns[1].Visible = false;
                dgv.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                dgv.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgv.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

                
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

                dgv.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgv.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgv.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgv.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgv.Columns[5].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo llenar la tabla" + ex.ToString());
            }
        }
    }
}
