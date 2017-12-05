using Front.App.CaseGerenciamentoTeste.Model;
using Front.App.CaseGerenciamentoTeste.View;
using Front.App.CaseGerenciamentoTeste.Properties;
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
    public partial class frmSelectCenario : Form
    {
        InteractionAPI api = new InteractionAPI();
        frmModelagemCenario frmmodelagemcen = new frmModelagemCenario();
        public frmSelectCenario(frmModelagemCenario frmmodelagemcen)
        {
            this.frmmodelagemcen = frmmodelagemcen;
            InitializeComponent();
        }

        private void frmSelectCenario_Load(object sender, EventArgs e)
        {
            loadComboBox();
        }

        private void loadComboBox()
        {
            cboProj.DataSource = JsonConvert.DeserializeObject<dynamic>(api.Get("api/projeto/select/listall"));
            cboProj.DisplayMember = "nome_proj";
            cboProj.ValueMember = "cod_proj";
            cboProj.SelectedIndex = -1;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {

                InteractionAPI api = new InteractionAPI();
                dgvCenarios.DataSource = JsonConvert.DeserializeObject<dynamic>(api.Get("api/cenario/select/forname/" + txtNome.Text + "/" + cboProj.SelectedValue));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDetalhes_Click(object sender, EventArgs e)
        {
            frmmodelagemcen.carregaConsulta(Convert.ToInt32(dgvCenarios.CurrentRow.Cells[0].Value));
            Close();
        }
    }
}
