using Back.DB.CaseGerenciamentoTeste.Models;
using System;
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
        Auth _auth = new Auth();
        public frmMenuPrincipal(Auth _auth)
        {
            this._auth = _auth;
            InitializeComponent();
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolfrmUser_Click(object sender, EventArgs e)
        {
            var frmuser = new frmUser();
            frmuser.MdiParent = this;
            frmuser.Show();
        }

        private void toolfrmProjeto_Click(object sender, EventArgs e)
        {
            var frmproj = new frmProjeto();
            frmproj.MdiParent = this;
            
            frmproj.Show();
        }

        private void toolfrmSistema_Click(object sender, EventArgs e)
        {
            var frmsis = new frmSistema();
            frmsis.MdiParent = this;
            frmsis.Show();
        }

        private void toolfrmModelagem_Click(object sender, EventArgs e)
        {
            var frmmod = new frmModelagemCenario(_auth);
            frmmod.MdiParent = this;
            MessageBox.Show("" + _auth.cod_usu);
            frmmod.Show();
        }

        private void toolFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
