using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_10
{
    public abstract class Funcionario
    {
        public double SalarioBase { get; set; }

        public Funcionario(double salario)
        {
            SalarioBase = salario;
        }

        public abstract double CalcularPagamento();
    }
}
