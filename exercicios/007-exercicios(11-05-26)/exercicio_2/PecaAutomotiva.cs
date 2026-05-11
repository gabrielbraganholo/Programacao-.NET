using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_2
{
    internal class PecaAutomotiva
    {
        protected string codigoPeca;
        protected decimal custoFabricacao;

        public PecaAutomotiva(string codigoPeca, decimal custoFabricacao)
        {
            this.codigoPeca = codigoPeca;
            this.custoFabricacao = custoFabricacao;
        }
    }
}
