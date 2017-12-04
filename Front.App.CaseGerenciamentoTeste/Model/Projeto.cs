using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Front.App.CaseGerenciamentoTeste.Model
{
    public class Projeto
    {
        public int cod_proj { get; set; }
        public string nome_proj { get; set; }
        public string objetivo_proj  { get; set; }
        public int cod_status_proj { get; set; }
    }
}
