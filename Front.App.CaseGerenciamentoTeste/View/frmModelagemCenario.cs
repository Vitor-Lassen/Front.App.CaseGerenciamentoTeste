﻿using Front.App.CaseGerenciamentoTeste.Model;
using Front.App.CaseGerenciamentoTeste.View;
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
    public partial class frmModelagemCenario : Form
    {
        InteractionAPI api = new InteractionAPI();
        Cenario _cen = new Cenario();
        public frmModelagemCenario()
        {
            InitializeComponent();
        }

        private void frmModelagemCenario_Load(object sender, EventArgs e)
        {
            loadComboBox();
        }

        private void loadComboBox()
        {
            cboProj.DataSource = JsonConvert.DeserializeObject<dynamic>(api.Get("api/projeto/select/listall"));
            cboProj.DisplayMember = "nome_proj";
            cboProj.ValueMember = "cod_proj";
            cboProj.SelectedIndex = -1;

            cboStatus.DataSource = JsonConvert.DeserializeObject<dynamic>(api.Get("api/statustype/select/listall"));
            cboStatus.DisplayMember = "statustype";
            cboStatus.ValueMember = "cod_status";
            cboStatus.SelectedIndex = -1;

        }

        private void btnAvancaCen_Click(object sender, EventArgs e)
        {
            
            try
            {
                _cen.nome_cen = txtNomeCen.Text;
                _cen.descri_cen = txtDesc.Text;
                _cen.cod_status_cen = Convert.ToInt32(cboStatus.SelectedValue);
                _cen.cod_proj_cen = Convert.ToInt32(cboProj.SelectedValue);
                //se for nulo, cria
                if (String.IsNullOrEmpty(txtCodCen.Text))
                {
                    InteractionAPI api = new InteractionAPI();
                    var response = api.Post("api/cenario/create", _cen);
                    _cen = JsonConvert.DeserializeObject<Cenario>(response);
                    carregaCampos();
                    MessageBox.Show("Salvo!");
                }
                //se nao for nulo, altera
                else
                {
                    _cen.cod_cen = Convert.ToInt32(txtCodCen.Text);
                    InteractionAPI api = new InteractionAPI();
                    var response = api.Post("api/cenario/update", _cen);
                    _cen = JsonConvert.DeserializeObject<Cenario>(response);
                    carregaCampos();
                    MessageBox.Show("Salvo!");
                }

                frmModelagemCaso frmmodelcaso = new frmModelagemCaso(this);
                frmmodelcaso.MdiParent = this;
                frmmodelcaso.ShowDialog();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public void carregaCampos()
        {
            txtCodCen.Text = _cen.cod_cen.ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            frmSelectCenario frmselectcen = new frmSelectCenario(this);
            frmMenuPrincipal mdi = new frmMenuPrincipal();
            frmselectcen.MdiParent = mdi;
            frmselectcen.ShowDialog();
        }
    }
}