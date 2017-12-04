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
    public partial class frmSelectUser : Form
    {
        frmUser userfrm = new frmUser();
        public frmSelectUser(frmUser userfrm)
        {
            this.userfrm = userfrm;
            InitializeComponent();
           
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try { 
                InteractionAPI api = new InteractionAPI();
                dgvUsers.DataSource = JsonConvert.DeserializeObject<dynamic>(api.Get("api/user/select/forname/" + txtNome.Text));
                }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDetalhes_Click(object sender, EventArgs e)
        {
            userfrm.carregaConsulta(Convert.ToInt32(dgvUsers.CurrentRow.Cells[0].Value));
            Close();
        }

        private void frmSelectUser_Load(object sender, EventArgs e)
        {

        }
    }
}
