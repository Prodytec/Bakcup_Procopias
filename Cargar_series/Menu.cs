using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cargar_series
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void cargarSeriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Series Series = new Series();
            Series.MdiParent = this;
            Series.Show();
        }

        private void exportarAExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exportar_excel Eex = new Exportar_excel();
            Eex.MdiParent = this;
            Eex.Show();
        }

        private void exportarAPDFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exportar_pdf Epdf = new Exportar_pdf();
            Epdf.MdiParent = this;
            Epdf.Show();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Acercade Acercade = new Acercade();
            Acercade.MdiParent = this;
            Acercade.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
