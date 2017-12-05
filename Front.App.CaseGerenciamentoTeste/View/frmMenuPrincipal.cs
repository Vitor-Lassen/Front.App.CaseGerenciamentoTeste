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
        frmLogin cod = new frmLogin();
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
            var frmmod = new frmModelagemCenario();
            frmmod.MdiParent = this;
            MessageBox.Show("cod_usu " + cod.cod_usu);
            frmmod.Show();
        }

        private void toolFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
