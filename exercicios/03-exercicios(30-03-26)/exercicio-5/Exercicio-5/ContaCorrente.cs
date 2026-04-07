using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_5
{
    public class ContaCorrente : Conta
    {
        public ContaCorrente(double saldo) : base(saldo)
        {
        }

        public override void Sacar(double valor)
        {
            if (saldo >= valor)
            {
                saldo -= valor;
            }
            else
            {
                Console.WriteLine("Saldo insuficiente");
            }
        }
    }
}
