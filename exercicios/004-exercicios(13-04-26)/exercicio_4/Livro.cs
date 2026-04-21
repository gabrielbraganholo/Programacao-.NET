using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_4
{
    class Livro : Produto
    {
        public override double CalcularDesconto()
        {
            return Preco * 0.05;
        }
    }
}
