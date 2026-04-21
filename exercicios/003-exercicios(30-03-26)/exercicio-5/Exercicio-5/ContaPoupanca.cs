using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_5
{
    public class ContaPoupanca : Conta
    {
        public ContaPoupanca(double saldo) : base(saldo)
        {
        }

        public override void Sacar(double valor)
        {
            double taxa = 0.50;

            if (saldo >= valor + taxa)
            {
                saldo -= valor + taxa;
            }
            else
            {
                Console.WriteLine("Saldo insuficiente");
            }
        }
    }
}
