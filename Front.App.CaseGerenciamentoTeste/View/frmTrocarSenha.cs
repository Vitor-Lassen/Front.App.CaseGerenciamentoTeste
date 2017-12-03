using Back.DB.CaseGerenciamentoTeste.Models;
using Front.App.CaseGerenciamentoTeste.Utilities;
using Newtonsoft.Json;
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
    public partial class frmTrocarSenha : Form
    {
        public frmTrocarSenha(Auth auth)
        {
            InitializeComponent();
            txtLogin.Text = auth.user;
            txtSenha.Text = auth.password;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
          
            try
            {
                AuthTrocaSenha _authTrocaSenha = new AuthTrocaSenha();
                _authTrocaSenha.user = txtLogin.Text;
                _authTrocaSenha.password = txtSenha.Text;
                _authTrocaSenha.newPassword = txtNovaSenha.Text;
                _authTrocaSenha.ConfirmNewPassword = txtConfiNovaSenha.Text;
                InteractionAPI api = new InteractionAPI();
                MessageBox.Show( api.Post("api/auth/trocasenha", _authTrocaSenha));
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); 
            }

        }

        private void frmTrocarSenha_Load(object sender, EventArgs e)
        {

        }
    }
}
