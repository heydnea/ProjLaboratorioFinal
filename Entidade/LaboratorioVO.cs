using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidade
{
    public class LaboratorioVO
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int qtdeComputadores { get; set; }
        public int qtdAlunos { get; set; }
        public bool projetor { get; set; }
        public string software1 { get; set; }
        public string software2 { get; set; }
        public string software3 { get; set; }
        public string sistemaOperacional { get; set; }
    }
}
