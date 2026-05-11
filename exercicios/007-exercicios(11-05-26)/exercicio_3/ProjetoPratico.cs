using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_3
{
    class ProjetoPratico : AtividadeAcademica
    {
        public ProjetoPratico(string titulo, decimal notaMaxima) : base(titulo, notaMaxima)
        {
        }

        public override decimal CalcularNotaFinal(decimal pontuacaoObtida)
        {
            decimal notaComBonus = pontuacaoObtida * 1.2M;

            if (notaComBonus > NotaMaxima)
            {
                return NotaMaxima;
            }

            return notaComBonus;
        }
    }
}
