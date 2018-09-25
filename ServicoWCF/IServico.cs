using Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicoWCF
{
   public  interface IServico
    {
        [OperationContract]
        bool Inserir(LaboratorioVO equipamento);

        [OperationContract]
        List<LaboratorioVO> Selecionar();

    }
}
