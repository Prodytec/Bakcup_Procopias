﻿using System;
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
    public partial class Series : Form
    {
        public Series()
        {
            InitializeComponent();
        }

        private void Series_Load(object sender, EventArgs e)
        {
            cbfiltro.Items.Add("Hoy");
            cbfiltro.Items.Add("Mes actual");
            cbfiltro.Items.Add("Personalizado");
        }
    }
}