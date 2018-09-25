using Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicoWCF
{
    public class Servico
    {
        public bool Inserir(LaboratorioVO laboratorio)
        {
            return new Dados.Dados().Inserir(laboratorio);
        }

        public List<LaboratorioVO> Selecionar()
        {
            return new Dados.Dados().Selecionar();
        }

    }
}
