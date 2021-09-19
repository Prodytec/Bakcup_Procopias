﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Formulas;

namespace Cargar_series
{
    public partial class Series : Form
    {
        public Series()
        {
            InitializeComponent();
        }
        Datagrid Datagrid = new Datagrid();
        private void Series_Load(object sender, EventArgs e)
        {
            cbfiltro.Items.Add("Mes actual");
            cbfiltro.Items.Add("Hoy");
            cbfiltro.Items.Add("Personalizado");
            cbfiltro.SelectedItem = cbfiltro.Items[0];

        }

        string Mes = "SP_fACTURAS_MES_ACTUAL";
        string Hoy = "SP_FACTURAS_HOY";
        string Personalizado = "SP_FACTURAS_PERSONALIZADAS";

        private void cbfiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbfiltro.SelectedIndex == 0 )
            {
                lbldesde.Visible = false;
                lblhasta.Visible = false;
                mtxtdesde.Visible = false;
                mtxthasta.Visible = false;
                Datagrid.Llenardatagrid(dgvfacturas, Mes);
                
            }
            else if(cbfiltro.SelectedIndex == 1)
            {
                lbldesde.Visible = false;
                lblhasta.Visible = false;
                mtxtdesde.Visible = false;
                mtxthasta.Visible = false;
                Datagrid.Llenardatagrid(dgvfacturas, Hoy);
            }
            else
            {
                lbldesde.Visible = true;
                lblhasta.Visible = true;
                mtxtdesde.Visible = true;
                mtxthasta.Visible = true;
            }
        }

        private void mtxthasta_Leave(object sender, EventArgs e)
        {
            Datagrid.Llenardatagrid(dgvfacturas, Personalizado, mtxtdesde, mtxthasta);
        }
    }
}
