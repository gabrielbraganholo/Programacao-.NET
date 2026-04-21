using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_9
{
    public class ProdutoNacional : Produto
    {
        public ProdutoNacional(double preco) : base(preco)
        {
        }

        public override double CalcularPreco()
        {
            return Preco;
        }
    }
}
