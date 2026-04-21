using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_3
{
    class ContaCorrente : ContaBancaria
    {
        private double taxa = 2.0;

        public override void Depositar(double valor)
        {
            if (valor > 0)
            {
                Saldo += valor;
            }
        }

        public override void Sacar(double valor)
        {
            double total = valor + taxa;

            if (total <= Saldo)
            {
                Saldo -= total;
            }
            else
            {
                Console.WriteLine("Saldo insuficiente.");
            }
        }

        public override void ExibirSaldo()
        {
            Console.WriteLine("Conta Corrente");
            base.ExibirSaldo();
        }
    }
}
