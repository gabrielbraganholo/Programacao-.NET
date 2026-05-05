using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_08
{
    internal class SaldoInsuficienteException : Exception
    {
        public SaldoInsuficienteException(string mensagem) : base(mensagem)
        {
        }
    }
}
