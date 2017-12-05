using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Front.App.CaseGerenciamentoTeste.Model
{
    public class Execucao
    {
        public int cod_exec { get; set; }
        public int cod_usu_exec { get; set; }
        public int cod_caso_exec { get; set; }
        public int cod_status_exec { get; set; }
        public string observacao_exec { get; set; }
    }
}
