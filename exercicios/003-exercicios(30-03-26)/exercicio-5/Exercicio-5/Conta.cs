using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_5
{
    public abstract class Conta
    {
        protected double saldo;

        public Conta(double saldo)
        {
            this.saldo = saldo;
        }

        public abstract void Sacar(double valor);

        public void MostrarSaldo()
        {
            Console.WriteLine($"Saldo: {saldo}");
        }
    }
}
