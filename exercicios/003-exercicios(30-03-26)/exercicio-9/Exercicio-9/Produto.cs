using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_9
{
    public abstract class Produto
    {
        public double Preco { get; set; }

        public Produto(double preco)
        {
            Preco = preco;
        }

        public abstract double CalcularPreco();
    }
}
