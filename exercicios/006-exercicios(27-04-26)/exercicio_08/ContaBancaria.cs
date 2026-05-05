using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_08
{
    internal class ContaBancaria
    {
        public decimal Saldo { get; set; }

        public ContaBancaria(decimal saldo)
        {
            Saldo = saldo;
        }

        public void Sacar(decimal valor)
        {
            if (valor > Saldo)
            {
                throw new SaldoInsuficienteException("Saldo insuficiente.");
            }

            Saldo -= valor;
        }
    }
}
