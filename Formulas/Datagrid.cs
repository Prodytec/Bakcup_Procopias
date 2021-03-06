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
        private SqlDataAdapter da = new SqlDataAdapter();
        private DataTable dt = new DataTable();
        private SqlCommand cmd = new SqlCommand();

        public void Llenardatagrid(DataGridView dgv, string Consulta, int Seleccion, string Campo, TextBox Valor)
        {
            string Desde = "";
            string Hasta = "";
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
                da.SelectCommand.Parameters.AddWithValue("@Desde", Desde);
                da.SelectCommand.Parameters.AddWithValue("@Hasta", Hasta);
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

        public void Grabar(DataGridView dgv, string Consulta, int Seleccion, string serie, string codigoart, int idimagen, int idinterno)
        {
            try
            {

                if (Seleccion == 1)
                {
                    da = new SqlDataAdapter(Consulta, cnn);
                    dt = new DataTable();
                    DataSet ds = new DataSet();
                    if (Consulta == "SP_SERIES")
                    {
                        da.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
                        da.SelectCommand.Parameters.AddWithValue("@Seleccion", Seleccion);
                        da.SelectCommand.Parameters.AddWithValue("@serie", serie);
                        da.SelectCommand.Parameters.AddWithValue("@codigoart", codigoart);
                        da.SelectCommand.Parameters.AddWithValue("@idimagenc", idimagen);
                        da.Fill(ds, Consulta);
                        dgv.DataSource = ds;
                        dgv.DataMember = "Sp_Series";
                    }
                    else if (Consulta == "SP_SERIES_REMITOS")
                    {
                        da.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
                        da.SelectCommand.Parameters.AddWithValue("@Seleccion", Seleccion);
                        da.SelectCommand.Parameters.AddWithValue("@serie", serie);
                        da.SelectCommand.Parameters.AddWithValue("@codigoart", codigoart);
                        da.SelectCommand.Parameters.AddWithValue("@idinterno", idinterno);
                        da.Fill(ds, Consulta);
                        dgv.DataSource = ds;
                        dgv.DataMember = "SP_SERIES_REMITOS";
                    }
                    else if(Consulta == "SP_SERIES_REMITOS_SERVICIOS")
                    {
                        da.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
                        da.SelectCommand.Parameters.AddWithValue("@Seleccion", Seleccion);
                        da.SelectCommand.Parameters.AddWithValue("@serie", serie);
                        da.SelectCommand.Parameters.AddWithValue("@codigoart", codigoart);
                        da.SelectCommand.Parameters.AddWithValue("@idinterno", idinterno);
                        da.Fill(ds, Consulta);
                        dgv.DataSource = ds;
                        dgv.DataMember = "SP_SERIES_REMITOS_SERVICIOS";
                    }
                    
                }
                else
                {
                    // connection();  
                    cnn.Open();
                    var transaccion = cnn.BeginTransaction();
                    if(Consulta == "SP_SERIES")
                    {
                        string query = "sp_series";         //Stored Procedure name   
                        SqlCommand com = new SqlCommand(query, cnn, transaccion);  //creating  SqlCommand  object  
                        com.CommandType = CommandType.StoredProcedure;  //here we declaring command type as stored 
                        com.Parameters.AddWithValue("@Seleccion", Seleccion);        //first Name  
                        com.Parameters.AddWithValue("@Serie ", serie.ToUpper());     //middle Name  
                        com.Parameters.AddWithValue("@codigoart", codigoart);
                        com.Parameters.AddWithValue("@idimagenc ", idimagen);//Last Name                               //
                        com.ExecuteNonQuery();
                        transaccion.Commit();
                        cnn.Close();
                    }
                    else if(Consulta == "SP_SERIES_REMITOS")
                    {
                        string query = "SP_SERIES_REMITOS";         //Stored Procedure name   
                        SqlCommand com = new SqlCommand(query, cnn, transaccion);  //creating  SqlCommand  object  
                        com.CommandType = CommandType.StoredProcedure;  //here we declaring command type as stored 
                        com.Parameters.AddWithValue("@Seleccion", Seleccion);        //first Name  
                        com.Parameters.AddWithValue("@Serie ", serie.ToUpper());     //middle Name  
                        com.Parameters.AddWithValue("@codigoart", codigoart);
                        com.Parameters.AddWithValue("@idinterno ", idinterno);//Last Name                               //
                        com.ExecuteNonQuery();
                        transaccion.Commit();
                        cnn.Close();
                    }
                    else if(Consulta == "SP_SERIES_REMITOS_SERVICIOS")
                    {
                        string query = "SP_SERIES_REMITOS_SERVICIOS";         //Stored Procedure name   
                        SqlCommand com = new SqlCommand(query, cnn, transaccion);  //creating  SqlCommand  object  
                        com.CommandType = CommandType.StoredProcedure;  //here we declaring command type as stored 
                        com.Parameters.AddWithValue("@Seleccion", Seleccion);        //first Name  
                        com.Parameters.AddWithValue("@Serie ", serie.ToUpper());     //middle Name  
                        com.Parameters.AddWithValue("@codigoart", codigoart);
                        com.Parameters.AddWithValue("@idinterno ", idinterno);//Last Name                               //
                        com.ExecuteNonQuery();
                        transaccion.Commit();
                        cnn.Close();
                    }
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puede grabar la serie" + ex.ToString());
            }
        }


        public void Llenardatagrid(DataGridView dgv, string Consulta, int idimagen)
        {
            try
            {
                if(Consulta == "ITEMS_SERIES_PROCOPIAS")
                {
                    da = new SqlDataAdapter(Consulta, cnn);
                    dt = new DataTable();
                    dgv.DataSource = dt;
                    DataSet ds = new DataSet();

                    da.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.AddWithValue("@idimagen", idimagen);

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
                else if(Consulta == "ITEMS_SERIES_PROCOPIAS_REMITOS" || Consulta == "ITEMS_SERIES_PROCOPIAS_REMITOS_SERVICIOS")
                {
                    da = new SqlDataAdapter(Consulta, cnn);
                    dt = new DataTable();
                    dgv.DataSource = dt;
                    DataSet ds = new DataSet();

                    da.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.AddWithValue("@idinterno", idimagen);

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

                
            }

            catch (Exception ex)
            {
                MessageBox.Show("No se pudo llenar la tabla" + ex.ToString());
            }
        }

        public void Buscargrid(DataGridView dgv, string Consulta, int Seleccion, string Campo, MaskedTextBox Valor)
        {
            string Desde = "";
            string Hasta = "";
            
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
                da.SelectCommand.Parameters.AddWithValue("@Desde", Desde);
                da.SelectCommand.Parameters.AddWithValue("@Hasta", Hasta);
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

        public void Cargarexcel(DateTimePicker Desdef, DateTimePicker Hastaf, DataGridView datagrid, ComboBox combo)
        {
            //llamo al store
            string store;
            store = "SP_EXPORTAR_EXCEL";
            SqlDataAdapter da = new SqlDataAdapter(store.Trim(), cnn);
            DataSet ds = new DataSet();

            //parametros
            da.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddWithValue("@desdef", Desdef.Text.ToString());
            da.SelectCommand.Parameters.AddWithValue("@hastaf", Hastaf.Text.ToString());
            da.SelectCommand.Parameters.AddWithValue("@desdep", combo.SelectedValue);
            da.SelectCommand.Parameters.AddWithValue("@hastap", combo.SelectedValue.ToString());
            da.Fill(ds, "store");
            cnn.Close();

            //mostrar en tabla
            datagrid.DataSource = ds;
            datagrid.DataMember = "store";

        }

        public void ExportarDataGridViewExcel(DataGridView grd)
        {
            SaveFileDialog fichero = new SaveFileDialog();
            fichero.Filter = "Excel (*.xls)|*.xls";
            if (fichero.ShowDialog() == DialogResult.OK)
            {
                Microsoft.Office.Interop.Excel.Application aplicacion;
                Microsoft.Office.Interop.Excel.Workbook libros_trabajo;
                Microsoft.Office.Interop.Excel.Worksheet hoja_trabajo;
                aplicacion = new Microsoft.Office.Interop.Excel.Application();
                libros_trabajo = aplicacion.Workbooks.Add();
                hoja_trabajo = (Microsoft.Office.Interop.Excel.Worksheet)libros_trabajo.Worksheets.get_Item(1);
                //Recorremos el DataGridView rellenando la hoja de trabajo
                //For para el titulo
                for (int i = 1; i < grd.Columns.Count + 1; i++)
                {
                    hoja_trabajo.Cells[1, i] = grd.Columns[i - 1].HeaderText;
                }
                //For para tabla
                for (int i = 0; i < grd.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < grd.Columns.Count; j++)
                    {
                        if (grd.Rows[i].Cells[j].Value != null)
                        {
                            hoja_trabajo.Cells[i + 2, j + 1] = grd.Rows[i].Cells[j].Value.ToString();
                        }
                        else
                        {
                            hoja_trabajo.Cells[i + 2, j + 1] = "";
                        }
                    }
                }
                libros_trabajo.SaveAs(fichero.FileName, Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal);
                libros_trabajo.Close(true);
                aplicacion.Quit();
                MessageBox.Show("La exportacion fue exitosa");
            }
        }

        public void llenarcombo(ComboBox combo)
        {
            string consulta = "select Nombre, idproveedor from proveedores order by Nombre";

            da = new SqlDataAdapter(consulta, cnn);
            DataTable lista = new DataTable();
            da.Fill(lista);

            combo.DisplayMember = "Nombre".Trim();
            combo.ValueMember = "idproveedor";
            combo.DataSource = lista;
        }

        public bool reccorergrilla(int nfila, string cContenido, DataGridView dgv)
        {
            foreach (DataGridViewRow row in dgv.Rows)
            {
                String cellText = Convert.ToString(row.Cells[0].Value);
                
                
                if (cellText.Trim().ToLower() == cContenido.Trim().ToLower() && nfila != row.Index && cContenido.Trim() != "")
                {
                    MessageBox.Show("Esta serie ya existe");
                    dgv.Rows[dgv.CurrentRow.Index].Cells[0].Value = "";
                    return false;
                }
            }
            return true;

        }
    }
}
