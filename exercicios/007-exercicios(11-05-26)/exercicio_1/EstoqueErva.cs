using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_1
{
    internal class EstoqueErva
    {
        private string marca;
        private decimal quantidadeQuilos;
        private decimal precoPorQuilo;

        public string Marca
        {
            get
            {
                return marca;
            }
            set
            {
                marca = value;
            }
        }

        public decimal QuantidadeQuilos
        {
            get
            {
                return quantidadeQuilos;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("QuantidadeQuilos não pode ser menor que zero.");
                }

                quantidadeQuilos = value;
            }
        }

        public decimal PrecoPorQuilo
        {
            get
            {
                return precoPorQuilo;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("PrecoPorQuilo não pode ser menor que zero.");
                }

                precoPorQuilo = value;
            }
        }

        public EstoqueErva(string marca, decimal quantidadeQuilos, decimal precoPorQuilo)
        {
            Marca = marca;
            QuantidadeQuilos = quantidadeQuilos;
            PrecoPorQuilo = precoPorQuilo;
        }
    }
}
