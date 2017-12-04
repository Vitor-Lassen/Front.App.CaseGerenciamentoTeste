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
    public partial class frmSelectSistema : Form
    {
        frmSistema frmsis = new frmSistema();
        public frmSelectSistema(frmSistema frmsis)
        {
            this.frmsis = frmsis;
            InitializeComponent();

        }

        private void frmSelectSistema_Load(object sender, EventArgs e)
        {

        }

        private void btnConsultaNome_Click(object sender, EventArgs e)
        {
            try
            {
                InteractionAPI api = new InteractionAPI();
                dgvSistemas.DataSource = JsonConvert.DeserializeObject<dynamic>(api.Get("api/sistema/select/forname/" + txtNome.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnConsultaSigla_Click(object sender, EventArgs e)
        {
            try
            {
                InteractionAPI api = new InteractionAPI();
                dgvSistemas.DataSource = JsonConvert.DeserializeObject<dynamic>(api.Get("api/sistema/select/forsigla/" + txtSigla.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDetalhes_Click(object sender, EventArgs e)
        {
            frmsis.carregaConsulta(Convert.ToInt32(dgvSistemas.CurrentRow.Cells[0].Value));
            Close();
        }
    }
}
