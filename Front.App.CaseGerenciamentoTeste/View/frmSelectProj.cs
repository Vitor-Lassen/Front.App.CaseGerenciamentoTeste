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
    public partial class frmSelectProj : Form
    {
        frmProjeto frmproj = new frmProjeto();
        public frmSelectProj(frmProjeto frmproj)
        {
            this.frmproj = frmproj;
            InitializeComponent();
        }
   
        private void btnConsultaProj_Click(object sender, EventArgs e)
        {
            try
            {
                InteractionAPI api = new InteractionAPI();
                dgvProjetos.DataSource = JsonConvert.DeserializeObject<dynamic>(api.Get("api/projeto/select/forname/" + txtNome.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDetalhes_Click(object sender, EventArgs e)
        {
            frmproj.carregaConsulta(Convert.ToInt32(dgvProjetos.CurrentRow.Cells[0].Value));
            Close();
        }

        private void frmSelectProj_Load(object sender, EventArgs e)
        {

        }
    }
}
