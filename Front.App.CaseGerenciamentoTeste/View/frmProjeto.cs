using Back.DB.CaseGerenciamentoTeste.Models;
using Front.App.CaseGerenciamentoTeste.Model;
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
    public partial class frmProjeto : Form
    {
        Projeto _proj = new Projeto();
        StatusType _status = new StatusType();
        SistemasxProjetos _sxp = new SistemasxProjetos();
        InteractionAPI api = new InteractionAPI();
        public frmProjeto()
        {
            InitializeComponent();
        }

        private void frmProjeto_Load(object sender, EventArgs e)
        {
            loadComboBox();   
            
        }
        private void loadComboBox()
        {
            cboStatus.DataSource = JsonConvert.DeserializeObject<dynamic>(api.Get("api/statustype/select/listall"));
            cboStatus.DisplayMember = "statustype";
            cboStatus.ValueMember = "cod_status";
            cboStatus.SelectedIndex = -1;

            cboAddSistema.DataSource = JsonConvert.DeserializeObject<dynamic>(api.Get("api/sistema/select/listall"));
            cboAddSistema.DisplayMember = "nome_sis";
            cboAddSistema.ValueMember = "cod_sis";
            cboAddSistema.SelectedIndex = -1;


        }

        private void btnAddSistema_Click(object sender, EventArgs e)
        {
           var response = api.Get("api/sistema/select/all/" + cboAddSistema.SelectedValue);
           Sistema sistema = JsonConvert.DeserializeObject<Sistema>(response);
           dgvSistemas.Rows.Add(sistema.cod_sis, sistema.nome_sis, sistema.sigla_sis);
        }

        public void carregaConsulta(int codProj)
        {
            try
            {
                if (codProj != 0)
                {
                    InteractionAPI api = new InteractionAPI();
                    _proj = JsonConvert.DeserializeObject<Projeto>(api.Get("api/projeto/select/all/" + codProj.ToString()));
                    carregaCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void carregaCampos()
        {
            txtNomeProj.Text = _proj.nome_proj;
            txtObjetivoProj.Text = _proj.objetivo_proj;
            var response = api.Get("api/statustype/select/statustypeforcod/" + _proj.cod_status_proj);
            cboStatus.Text = response;
            dgvSistemas.DataSource = JsonConvert.DeserializeObject<dynamic>(api.Get("api/sistema/select/sistemasprojeto/" + _proj.cod_proj));
            //var sisxproj = api.Get("api/sistema/select/sistemasprojeto/" + _proj.cod_proj);
            //Sistema sistema = JsonConvert.DeserializeObject<dynamic>(api.Get("api/sistema/select/sistemasprojeto/" + _proj.cod_proj));
            //dgvSistemas.Rows.Add(sistema.cod_sis, sistema.nome_sis, sistema.sigla_sis);
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            var frmselectproj = new frmSelectProj();
            frmselectproj.MdiParent = this;
            frmselectproj.Show();
        }

        private void cboStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                _proj.nome_proj = txtNomeProj.Text;
                _proj.objetivo_proj = txtObjetivoProj.Text;
                _proj.cod_status_proj = Convert.ToInt32(cboStatus.ValueMember);
                //se for nulo, cria
                if (String.IsNullOrEmpty(txtCodProj.Text))
                {
                    InteractionAPI api = new InteractionAPI();
                    var response = api.Post("api/projeto/create", _proj);
                    _proj = JsonConvert.DeserializeObject<Projeto>(response);
                    carregaCampos();
                    MessageBox.Show("Salvo!");
                }
                //se nao for nulo, altera
                else
                {
                    _proj.cod_proj = Convert.ToInt32(txtCodProj.Text);
                    InteractionAPI api = new InteractionAPI();
                    var response = api.Post("api/projeto/update", _proj);
                    _proj = JsonConvert.DeserializeObject<Projeto>(response);
                    carregaCampos();
                    MessageBox.Show("Salvo!");
                }
                salvaSistemasXProjeto();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void salvaSistemasXProjeto()
        {
            int i;
            for (i=0;i<=dgvSistemas.RowCount;i++)
            {
                _sxp.cod_proj_projxsis = Convert.ToInt32(txtCodProj.Text);
                _sxp.cod_proj_projxsis = Convert.ToInt32(dgvSistemas.Rows[i].Cells[0].Value);
                InteractionAPI api = new InteractionAPI();
                var response = api.Post("api/projetoxsistema/create", _sxp);
                _sxp = JsonConvert.DeserializeObject<SistemasxProjetos>(response);
            }
        }
    }
}
