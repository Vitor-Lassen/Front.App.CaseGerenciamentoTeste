using Back.DB.CaseGerenciamentoTeste.Models;
using Front.App.CaseGerenciamentoTeste.Model;
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

namespace Front.App.CaseGerenciamentoTeste
{
    public partial class frmSistema : Form
    {
        Sistema _sis = new Sistema();
        InteractionAPI api = new InteractionAPI();

        public frmSistema()
        {
            InitializeComponent();
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnConsultaSis_Click(object sender, EventArgs e)
        {
            frmSelectSistema selectSistema = new frmSelectSistema(this);
            selectSistema.ShowDialog();
        }

        public void carregaConsulta(int codSis)
        {
            try
            {
                if (codSis != 0)
                {
                    InteractionAPI api = new InteractionAPI();
                    _sis = JsonConvert.DeserializeObject<Sistema>(api.Get("api/sistema/select/all/" + codSis.ToString()));
                    carregaCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void carregaCampos()
        {
            txtCodSis.Text = _sis.cod_sis.ToString();
            txtNome.Text = _sis.nome_sis;
            txtSigla.Text = _sis.sigla_sis;
            cboStatus.SelectedItem = JsonConvert.DeserializeObject<dynamic>(api.Get("api/statustype/select/statustypeforcod/" + _sis.cod_status_sis));
        }
        private void loadComboBox()
        {
            cboStatus.DataSource = JsonConvert.DeserializeObject<dynamic>(api.Get("api/statustype/select/listall"));
            cboStatus.DisplayMember = "statustype";
            cboStatus.ValueMember = "cod_status";
            cboStatus.SelectedIndex = -1;
        }

        private void frmSistema_Load(object sender, EventArgs e)
        {
            loadComboBox();
        }

        private void btnCadastroSis_Click(object sender, EventArgs e)
        {
            try
            {
                _sis.nome_sis = txtNome.Text;
                _sis.sigla_sis = txtSigla.Text;
                _sis.cod_status_sis = Convert.ToInt32(cboStatus.SelectedValue);
                //se for nulo, cria
                if (String.IsNullOrEmpty(txtCodSis.Text))
                {
                    InteractionAPI api = new InteractionAPI();
                    var response = api.Post("api/sistema/create", _sis);
                    _sis = JsonConvert.DeserializeObject<Sistema>(response);
                    carregaCampos();
                    MessageBox.Show("Salvo!");
                }
                //se nao for nulo, altera
                else
                {
                    _sis.cod_sis = Convert.ToInt32(txtCodSis.Text);
                    //_sis.cod_status_sis = Convert.ToInt32(cboStatus.SelectedValue);
                    InteractionAPI api = new InteractionAPI();
                    var response = api.Post("api/sistema/update", _sis);
                    _sis = JsonConvert.DeserializeObject<Sistema>(response);
                    carregaCampos();
                    MessageBox.Show("Salvo!");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
}
    }
}
