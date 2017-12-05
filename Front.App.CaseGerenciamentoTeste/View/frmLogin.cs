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
    public partial class frmLogin : Form
    {
        Auth _auth = new Auth();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                //essa fita é prara jogar a txtbox pro parametro da API
                _auth.user = txtLogin.Text;
                _auth.password = txtSenha.Text;
                InteractionAPI api = new InteractionAPI();
                _auth = JsonConvert.DeserializeObject<Auth> (api.Post("api/auth", _auth));
                if ((bool)_auth.auth)
                {
                    if ((bool)_auth.trocasenha)
                    {
                        frmTrocarSenha trocaSenhafrm = new frmTrocarSenha(_auth);
                        txtSenha.Text = "";
                        trocaSenhafrm.ShowDialog();
                    }
                    else
                    {
                        var frmmainmenu = new frmMenuPrincipal(_auth);
                        frmmainmenu.Show();
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Usuário ou senha inválidos");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
               
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
