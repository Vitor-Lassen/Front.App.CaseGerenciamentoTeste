﻿using Front.App.CaseGerenciamentoTeste.Model;
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
        User _user = new User();
        Limpar _limpar = new Limpar();
        
        public frmUser()
        {
           
            InitializeComponent();
           
        }

        private void txtCod_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtCod.Text))
            {
                txtSenha.ReadOnly = true;
                chekTrocaSenha.Checked = true;
                chekTrocaSenha.Enabled = false;
            }
            else
            {
                txtSenha.ReadOnly = false;
                chekTrocaSenha.Enabled = true;
            }
        }
        private void carregaCampos()
        {
            txtNome.Text= _user.nome_usu;
            txtSobrenome.Text= _user.sobrenome_usu ;
            txtEmail.Text= _user.email_usu ;
            cboAcesso.SelectedIndex = _user.permissao_usu ;
            txtSenha.Text=_user.senha_usu ;
            txtCod.Text = _user.cod_usu.ToString();
            txtLogin.Text = _user.login_usu;
            chekTrocaSenha.Checked = _user.troca_senha;
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if ((!String.IsNullOrEmpty(txtNome.Text)) && (!String.IsNullOrEmpty(txtSobrenome.Text)) && (cboAcesso.SelectedIndex != -1))
            {
                try
                {
                    _user.nome_usu = txtNome.Text;
                    _user.sobrenome_usu = txtSobrenome.Text;
                    _user.email_usu = txtEmail.Text;
                    _user.permissao_usu = cboAcesso.SelectedIndex;
                    _user.senha_usu = txtSenha.Text;
                    _user.troca_senha = chekTrocaSenha.Checked;
                    //se for nulo, cria
                    if (String.IsNullOrEmpty(txtCod.Text))
                    {
                        InteractionAPI api = new InteractionAPI();
                        var response = api.Post("api/user/create", _user);
                        _user = JsonConvert.DeserializeObject<User>(response);
                        carregaCampos();
                        MessageBox.Show("Salvo!");
                    }
                    //se nao for nulo, altera
                    else
                    {
                        _user.cod_usu = Convert.ToInt32(txtCod.Text);
                        InteractionAPI api = new InteractionAPI();
                        var response = api.Post("api/user/update", _user);
                        _user = JsonConvert.DeserializeObject<User>(response);
                        carregaCampos();
                        MessageBox.Show("Salvo!");

                    }
                    _limpar.limpar(groupBox1);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Preencha os campos:\nNome, Sobrenome e Acesso \nPara Cadastrar.");
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            frmSelectUser selectUser = new frmSelectUser(this);
            
            selectUser.ShowDialog();
            
        }
        public void carregaConsulta (int codUser)
        {
            try { 
            if (codUser != 0)
            {
                InteractionAPI api = new InteractionAPI();
                _user = JsonConvert.DeserializeObject<User>(api.Get("api/user/select/all/" + codUser.ToString()));
                carregaCampos();
            }
        }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmUser_Load(object sender, EventArgs e)
        {
            txtCod_TextChanged(sender, e);
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            _limpar.limpar(groupBox1);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
