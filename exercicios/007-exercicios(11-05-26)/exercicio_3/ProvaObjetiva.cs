using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_3
{
    class ProvaObjetiva : AtividadeAcademica
    {
        public ProvaObjetiva(string titulo, decimal notaMaxima)
            : base(titulo, notaMaxima)
        {
        }

        public override decimal CalcularNotaFinal(decimal pontuacaoObtida)
        {
            if (pontuacaoObtida > NotaMaxima)
            {
                return NotaMaxima;
            }

            return pontuacaoObtida;
        }
    }
}
