using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_3
{
    class ContaPoupanca : ContaBancaria
    {
        public override void Depositar(double valor)
        {
            if (valor > 0)
            {
                Saldo += valor;
            }
        }

        public override void Sacar(double valor)
        {
            if (valor <= Saldo)
            {
                Saldo -= valor;
            }
            else
            {
                Console.WriteLine("Não é possível sacar valor maior que o saldo.");
            }
        }
        public override void ExibirSaldo()
        {
            Console.WriteLine("Conta Poupança");
            base.ExibirSaldo();
        }
    }
}
