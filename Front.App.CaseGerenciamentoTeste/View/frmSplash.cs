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
    public partial class frmSplash : Form
    {
        public frmSplash()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void frmSplash_Load(object sender, EventArgs e)
        {
            frmLogin loginfrm = new frmLogin();
            loginfrm.Show();
            Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Visible = false;
            
            
                timer1.Stop();

                
            
        }
    }
}
