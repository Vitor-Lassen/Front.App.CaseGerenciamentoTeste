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
        frmModelagemCenario frmmodcen = new frmModelagemCenario();
        public frmSelectCenario(frmModelagemCenario frmmodelagemcen)
        {
            this.frmmodcen = frmmodelagemcen;
            InitializeComponent();
        }

        private void frmSelectCenario_Load(object sender, EventArgs e)
        {

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                InteractionAPI api = new InteractionAPI();
                dgvCenarios.DataSource = JsonConvert.DeserializeObject<dynamic>(api.Get("api/cenario/select/forname/" + txtNome.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
