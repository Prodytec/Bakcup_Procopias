using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Deployment.Application;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cargar_series
{
    public partial class Acercade : Form
    {
        public Acercade()
        {
            InitializeComponent();
        }

        private void Acercade_Load(object sender, EventArgs e)
        {
            //Version clickonce
            if (ApplicationDeployment.IsNetworkDeployed)
            {
                lblversion.Text = "Versión: " + ApplicationDeployment.CurrentDeployment.CurrentVersion.ToString();
            }
        }
    }
}
