using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_9
{
    public class Carrinho
    {
        public List<Produto> lista = new List<Produto>();

        public double Total()
        {
            double total = 0;

            foreach (var p in lista)
            {
                total += p.CalcularPreco();
            }

            return total;
        }
    }
}
