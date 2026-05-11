using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_2
{
    internal class PecaAcabamento : PecaAutomotiva
    {
        public string CorIluminacao { get; set; }
        public int Voltagem { get; set; }

        public PecaAcabamento(string codigoPeca, decimal custoFabricacao, string corIluminacao, int voltagem) : base(codigoPeca, custoFabricacao)
        {
            CorIluminacao = corIluminacao;
            Voltagem = voltagem;
        }

        public decimal CalcularPrecoVenda(decimal margemLucro)
        {
            decimal precoFinal = custoFabricacao + (custoFabricacao * (margemLucro / 100));

            return precoFinal;
        }
    }
}
