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
    public partial class frmModelagemCaso : Form
    {
        
        InteractionAPI api = new InteractionAPI();
        Limpar _limpar = new Limpar();
        Caso _caso = new Caso();
        Auth _auth = new Auth();
        Cenario _cen = new Cenario();
        frmModelagemCenario frm = new frmModelagemCenario();
        
        public frmModelagemCaso(Cenario _cen, Auth _auth, frmModelagemCenario frm)
        {
            this._cen = _cen;
            this._auth = _auth;
            InitializeComponent();
        }

        private void frmModelagemCaso_Load(object sender, EventArgs e)
        {
            txtCodCen.Text = _cen.cod_cen.ToString();
            loadComboBox();
        }

        private void loadComboBox()
        {
            cboStatus.DataSource = JsonConvert.DeserializeObject<dynamic>(api.Get("api/statustype/select/listall"));
            cboStatus.DisplayMember = "statustype";
            cboStatus.ValueMember = "cod_status";
            cboStatus.SelectedIndex = -1;
           
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            _limpar.limpar(gbcaso);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdicionaCaso_Click(object sender, EventArgs e)
        {
            try
            {
                _caso.nome_caso = txtNomeCaso.Text;
                _caso.precond_caso = txtPreCond.Text;
                _caso.massadados_caso = txtMassaDado.Text;
                _caso.resultesp_caso = txtResultEsp.Text;
                _caso.cod_usu_caso = _auth.cod_usu;
                //_caso.resultesp_caso = " ";
                _caso.cod_cen_caso = Convert.ToInt32(txtCodCen.Text);
                _caso.cod_status_caso = Convert.ToInt32(cboStatus.SelectedValue);
                //se for nulo, cria
                if (String.IsNullOrEmpty(txtCodCaso.Text))
                {
                    InteractionAPI api = new InteractionAPI();
                    carregaCampos();
                    var response = api.Post("api/caso/create", _caso);
                    _caso = JsonConvert.DeserializeObject<Caso>(response);
                    MessageBox.Show("Salvo!");
                }
                //se nao for nulo, altera
                else
                {
                    _caso.cod_caso = Convert.ToInt32(txtCodCaso.Text);
                    InteractionAPI api = new InteractionAPI();
                    var response = api.Post("api/caso/update", _caso);
                    _caso = JsonConvert.DeserializeObject<Caso>(response);
                    MessageBox.Show("Salvo!");
                }
                _limpar.limpar(gbcaso);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void carregaCampos()
        {
            txtCodCaso.Text = _caso.cod_caso.ToString();
        }
    }
    }

