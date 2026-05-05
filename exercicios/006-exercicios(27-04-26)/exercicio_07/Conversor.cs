using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_07
{
    internal class Conversor
    {
        public static void Executar()
        {
            Console.Write("Digite um número: ");
            string entrada = Console.ReadLine();

            if (int.TryParse(entrada, out int numero))
            {
                Console.WriteLine(numero);
            }
            else
            {
                Console.WriteLine("Entrada inválida.");
            }
        }
    }
}
