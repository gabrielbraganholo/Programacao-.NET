using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_10
{
    public class Gerente : Funcionario
    {
        public double Bonus { get; set; }

        public Gerente(double salario, double bonus) : base(salario)
        {
            Bonus = bonus;
        }

        public override double CalcularPagamento()
        {
            return SalarioBase + Bonus;
        }
    }
}
