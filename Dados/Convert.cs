using Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
     public class Convert
    {
        public static Laboratorio ConvertToLaboratorio(LaboratorioVO laboratorioVO)
        {
            return new Laboratorio()
            {
                id = laboratorioVO.Id,
                nome = laboratorioVO.Nome,
                qtdeComputadores = laboratorioVO.qtdeComputadores,
                qtdeAlunos = laboratorioVO.qtdAlunos,
                projetor = laboratorioVO.projetor,
                software1 = laboratorioVO.software1,
                software2 = laboratorioVO.software2,
                software3 = laboratorioVO.software3,
                sistemaOperacional = laboratorioVO.sistemaOperacional
            };
        }

        public static LaboratorioVO ConvertToLaboratorioVO(Laboratorio laboratorio)
        {
            return new LaboratorioVO()
            {
                Id = laboratorio.id,
                Nome = laboratorio.nome,
                qtdeComputadores = (int)laboratorio.qtdeComputadores,
                qtdAlunos = (int)laboratorio.qtdeAlunos,
                projetor = (bool)laboratorio.projetor,
                software1 = laboratorio.software1,
                software2 = laboratorio.software2,
                software3 = laboratorio.software3,
                sistemaOperacional = laboratorio.sistemaOperacional
            };
        }
        
        public static List<LaboratorioVO> ConvertListLaboratorioVO(List<Laboratorio> lstLabaratorio)
        {
            List<LaboratorioVO> lstlaboratorioVO = new List<LaboratorioVO>();

            foreach (var item in lstLabaratorio)
            {
                lstlaboratorioVO.Add(ConvertToLaboratorioVO(item));
            }

            return lstlaboratorioVO;
        }
     }
}
