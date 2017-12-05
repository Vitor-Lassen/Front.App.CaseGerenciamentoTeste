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
    public partial class frmStatus : Form
    {
        Limpar _limpar = new Limpar();
        StatusType _stype = new StatusType();
        public frmStatus()
        {
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            _limpar.limpar(groupBox1);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                _stype.statustype = txtStatus.Text;
                //se for nulo, cria
                if (String.IsNullOrEmpty(txtCod.Text))
                {
                    InteractionAPI api = new InteractionAPI();
                    var response = api.Post("api/statustype/create", _stype);
                    _stype = JsonConvert.DeserializeObject<StatusType>(response);
                    MessageBox.Show("Salvo!");
                }
                //se nao for nulo, altera
                else
                {
                    _stype.cod_status = Convert.ToInt32(txtCod.Text);
                    InteractionAPI api = new InteractionAPI();
                    var response = api.Post("api/statustype/update", _stype);
                    _stype = JsonConvert.DeserializeObject<StatusType>(response);
                    MessageBox.Show("Salvo!");
                }
                _limpar.limpar(groupBox1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void carregaCampos()
        {
            txtCod.Text = _stype.cod_status.ToString();
            txtStatus.Text = _stype.statustype;
        }
    }
}
