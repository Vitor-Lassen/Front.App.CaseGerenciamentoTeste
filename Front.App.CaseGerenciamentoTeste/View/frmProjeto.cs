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
        InteractionAPI _api = new InteractionAPI();
        Limpar _limpar = new Limpar();
        SistemasxProjetos _sxp = new SistemasxProjetos();
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
            cboStatus.DataSource = JsonConvert.DeserializeObject<dynamic>(_api.Get("api/statustype/select/listall"));
            cboStatus.DisplayMember = "statustype";
            cboStatus.ValueMember = "cod_status";
            cboStatus.SelectedIndex = -1;

            cboAddSistema.DataSource = JsonConvert.DeserializeObject<dynamic>(_api.Get("api/sistema/select/listall"));
            cboAddSistema.DisplayMember = "nome_sis";
            cboAddSistema.ValueMember = "cod_sis";
            cboAddSistema.SelectedIndex = -1;
        }

        private void btnAddSistema_Click(object sender, EventArgs e)
        {
           var response = _api.Get("api/sistema/select/all/" + cboAddSistema.SelectedValue);
           Sistema sistema = JsonConvert.DeserializeObject<Sistema>(response);
           dgvSistemas.Rows.Add(sistema.cod_sis, sistema.nome_sis, sistema.sigla_sis);
        }

        public void carregaConsulta(int codProj)
        {
            try
            {
                if (codProj != 0)
                {
                    _limpar.limpar(groupBox1);
                    _proj = JsonConvert.DeserializeObject<Projeto>(_api.Get("api/projeto/select/all/" + codProj.ToString()));
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
            txtCodProj.Text = _proj.cod_proj.ToString();
            
            string status = JsonConvert.DeserializeObject<dynamic>(_api.Get("api/statustype/select/statustypeforcod/" + _proj.cod_status_proj)).statustype;
            cboStatus.SelectedIndex  = cboStatus.FindStringExact(status);
            var resultSistemasProj = JsonConvert.DeserializeObject<dynamic>(_api.Get("api/sistema/select/sistemasprojeto/" + _proj.cod_proj));
            foreach (var row in resultSistemasProj)
            {
                dgvSistemas.Rows.Add(row.cod_sis, row.nome_sis, row.sigla_sis,row.cod_projxsis);
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            var frmselectproj = new frmSelectProj(this);
            frmselectproj.ShowDialog();
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
                _proj.cod_status_proj = Convert.ToInt32(cboStatus.SelectedValue);
                //se for nulo, cria
                if (String.IsNullOrEmpty(txtCodProj.Text))
                {
                    var response = _api.Post("api/projeto/create", _proj);
                    _proj = JsonConvert.DeserializeObject<Projeto>(response);
                }
                //se nao for nulo, altera
                else
                {
                    var response = _api.Post("api/projeto/update", _proj);
                    _proj = JsonConvert.DeserializeObject<Projeto>(response);
                }
                salvaSistemasXProjeto();
                _limpar.limpar(groupBox1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void salvaSistemasXProjeto()
        {

            _sxp.cod_proj_projxsis = _proj.cod_proj;
            foreach (DataGridViewRow row in dgvSistemas.Rows)
            {
                if (row.Cells[3].Value == null)
                {
                    _sxp.cod_sis_projxsis = Convert.ToInt32(row.Cells[0].Value);
                    
                    var response = _api.Post("api/projetoxsistema/create", _sxp);
                    _sxp = JsonConvert.DeserializeObject<SistemasxProjetos>(response);
                    row.Cells[3].Value = _sxp.cod_projxsis;
                }
            }
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
