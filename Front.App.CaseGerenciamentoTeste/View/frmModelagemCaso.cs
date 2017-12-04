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
        frmModelagemCenario frmmodelcaso = new frmModelagemCenario();
        InteractionAPI api = new InteractionAPI();
        public frmModelagemCaso(frmModelagemCenario frmmodelcaso)
        {
            this.frmmodelcaso = frmmodelcaso;
            InitializeComponent();
        }

        private void frmModelagemCaso_Load(object sender, EventArgs e)
        {
            loadComboBox();

        }
        private void loadComboBox()
        {
            
        }
    }
    }

