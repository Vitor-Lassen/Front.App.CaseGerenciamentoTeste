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
    
    public partial class frmExecucao : Form
    {
        InteractionAPI api = new InteractionAPI();
        public frmExecucao()
        {
            InitializeComponent();
        }

        private void frmExecucao_Load(object sender, EventArgs e)
        {
            loadComboBox();
            btnExec.Visible = false;
            btnCenCaso.Visible = false;
        }

        private void loadComboBox()
        {
                cboProj.DataSource = JsonConvert.DeserializeObject<dynamic>(api.Get("api/projeto/select/listall"));
                cboProj.DisplayMember = "nome_proj";
                cboProj.ValueMember = "cod_proj";
                cboProj.SelectedIndex = -1;    
        }

        private void cboProj_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cboCenario_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnProjCen_Click(object sender, EventArgs e)
        {
            try
            {
                cboCenario.DataSource = JsonConvert.DeserializeObject<dynamic>(api.Get("api/cenario/select/listallforproject/" + cboProj.SelectedValue));
                cboCenario.DisplayMember = "Nome Cenário";
                cboCenario.ValueMember = "Código";
                cboCenario.SelectedIndex = -1;
                btnProjCen.Visible = false;
                btnCenCaso.Visible = true;
            }
            catch
            {
                
            }

        }

        private void btnCenCaso_Click(object sender, EventArgs e)
        {
            cboCaso.DataSource = JsonConvert.DeserializeObject<dynamic>(api.Get("api/caso/select/forcenario/" + cboCenario.SelectedValue));
            cboCaso.DisplayMember = "Nome";
            cboCaso.ValueMember = "Código";
            cboCaso.SelectedIndex = -1;
            btnExec.Visible = true;
            btnCenCaso.Visible = false;
        }

        private void btnExec_Click(object sender, EventArgs e)
        {

        }
    }
}
