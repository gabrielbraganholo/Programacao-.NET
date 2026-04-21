using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_3
{
    abstract class ContaBancaria
    {
        public double Saldo { get; protected set; }

        public abstract void Depositar(double valor);

        public abstract void Sacar(double valor);

        public virtual void ExibirSaldo()
        {
            Console.WriteLine("Saldo: R$ " + Saldo);
        }
    }
}
