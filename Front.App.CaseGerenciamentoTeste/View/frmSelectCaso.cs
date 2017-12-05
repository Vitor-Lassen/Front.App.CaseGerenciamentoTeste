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
    public partial class frmSelectCaso : Form
    {

        frmModelagemCaso frm = new frmModelagemCaso();
        InteractionAPI api = new InteractionAPI();
        public frmSelectCaso(frmModelagemCaso frm)
        {
            this.frm = frm;
            InitializeComponent();
        }

        private void frmSelectCaso_Load(object sender, EventArgs e)
        {
            
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                InteractionAPI api = new InteractionAPI();
                dgvCasos.DataSource = JsonConvert.DeserializeObject<dynamic>(api.Get("api/caso/select/forname/" + txtNome.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDetalhes_Click(object sender, EventArgs e)
        {
            frm.carregaConsulta(Convert.ToInt32(dgvCasos.CurrentRow.Cells[0].Value));
            Close();
        }
    }
}
