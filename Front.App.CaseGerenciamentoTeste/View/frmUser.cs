using Front.App.CaseGerenciamentoTeste.Model;
using Front.App.CaseGerenciamentoTeste.Utilities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Front.App.CaseGerenciamentoTeste.View
{
    public partial class frmUser : Form
    {
        public frmUser()
        {
            InitializeComponent();
        }

        private void txtCod_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtCod.Text))
            {
                btnNovo.Visible = false;
                btnSalvar.Text = "Cadastrar";
            }
            else
            {
                btnNovo.Visible = true;
                btnSalvar.Text = "Salvar"; 
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            User user = new User();
            
            user.nomeUsu = txtNome.Text;
            user.sobrenomeUsu = txtSobrenome.Text;
            user.email = txtEmail.Text;
            user.permissaoUsu = cboAcesso.SelectedIndex;
            user.senhaUsu = txtSenha.Text;
            if (String.IsNullOrEmpty(txtCod.Text))
            {
                string json = JsonConvert.SerializeObject(user);
                StringContent content = new StringContent(json);
                content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                HttpClient teste = new HttpClient();
                teste.PostAsync("http://localhost:50949/api/create/user", content);

            }   
            else
            {

                user.cod = Convert.ToInt32(txtCod.Text);
                btnNovo.Visible = true;
                btnSalvar.Text = "Salvar";
            }
        }
    }
}
