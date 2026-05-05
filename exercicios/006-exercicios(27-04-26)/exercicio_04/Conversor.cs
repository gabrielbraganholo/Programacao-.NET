using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_04
{
    internal class Conversor
    {
        public static void Executar()
        {
            try
            {
                object minhaString = "123";

                int numero = (int)minhaString;

                Console.WriteLine(numero);
            }
            catch (InvalidCastException)
            {
                Console.WriteLine("InvalidCastException ocorreu porque não é possível converter diretamente uma string para int usando cast.");
            }
        }
    }
}
