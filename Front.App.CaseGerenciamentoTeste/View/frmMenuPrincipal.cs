﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Front.App.CaseGerenciamentoTeste.View
{
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolfrmUser_Click(object sender, EventArgs e)
        {
            var frmuser = new frmUser();
            frmuser.Show();
        }

        private void toolfrmProjeto_Click(object sender, EventArgs e)
        {
            var frmproj = new frmProjeto();
            frmproj.Show();
        }
    }
}