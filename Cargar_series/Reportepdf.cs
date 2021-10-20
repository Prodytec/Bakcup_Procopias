using Formulas;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace Cargar_series
{
    public partial class Reportepdf : Form
    {
        public Reportepdf()
        {
            InitializeComponent();
        }

        public int idimagen;
        public string nombrecli;
        public string numerofc;
        public string fecha;

        private void Reportepdf_Load(object sender, EventArgs e)
        {
            DataSet D = new DataSet();
            SqlConnection cnn = Conexionbd.DbConnection.getDBConnection();
            string sp = "SP_REPORTE_PDF_PROCOPIAS";
            SqlDataAdapter da = new SqlDataAdapter(sp, cnn);
            da.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddWithValue("@IDIMAGEN", idimagen);
            da.Fill(D, sp);

            ReportDataSource Rds = new ReportDataSource("DataSet1", D.Tables[0]);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(Rds);

            //parametros del reporte
            ReportParameter[] parameters = new ReportParameter[3];
            parameters[0] = new ReportParameter("Nombrecliente", nombrecli);
            parameters[1] = new ReportParameter("Numerofactura", numerofc);
            parameters[2] = new ReportParameter("Fechafactura", fecha);
            this.reportViewer1.LocalReport.SetParameters(parameters);
            this.reportViewer1.LocalReport.Refresh();
            this.reportViewer1.RefreshReport();
        }
    }
}

