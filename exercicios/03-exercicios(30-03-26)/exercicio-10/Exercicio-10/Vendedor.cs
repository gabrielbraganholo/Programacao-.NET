using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_10
{
    public class Vendedor : Funcionario
    {
        public double Vendas { get; set; }

        public Vendedor(double salario, double vendas) : base(salario)
        {
            Vendas = vendas;
        }

        public override double CalcularPagamento()
        {
            return SalarioBase + (Vendas * 0.10);
        }
    }
}
