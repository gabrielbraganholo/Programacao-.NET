using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_3
{
    class ContaSalario : ContaBancaria
    {
        public override void Depositar(double valor)
        {
            Console.WriteLine("Conta salário não permite depósito manual.");
        }

        public override void Sacar(double valor)
        {
            if (valor <= Saldo)
            {
                Saldo -= valor;
            }
            else
            {
                Console.WriteLine("Saldo insuficiente.");
            }
        }

        public void DepositoEmpresa(double valor)
        {
            Saldo += valor;
        }

        public override void ExibirSaldo()
        {
            Console.WriteLine("Conta Salário");
            base.ExibirSaldo();
        }
    }
}
