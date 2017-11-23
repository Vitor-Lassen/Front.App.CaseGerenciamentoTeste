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

    }
}
