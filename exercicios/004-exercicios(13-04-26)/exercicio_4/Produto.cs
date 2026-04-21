using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_4
{
    abstract class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }

        public abstract double CalcularDesconto();

        public void ExibirPrecoFinal()
        {
            double desconto = CalcularDesconto();
            double precoFinal = Preco - desconto;

            Console.WriteLine("Produto: " + Nome);
            Console.WriteLine("Preço original: R$ " + Preco);
            Console.WriteLine("Preço com desconto: R$ " + precoFinal);
            Console.WriteLine();
        }
    }
}
