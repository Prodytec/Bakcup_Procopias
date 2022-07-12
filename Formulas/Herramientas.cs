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
    public class Herramientas
    {
        public void LimpiarGrid(DataGridView Dg)
        {
            Dg.DataSource = null;
            Dg.Rows.Clear();
            Dg.Refresh();
        }
    }
}
