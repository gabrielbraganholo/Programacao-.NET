using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_01
{
    internal class Leitor
    {
        public static void Executar()
        {
            try
            {
                Console.Write("Digite um número inteiro: ");
                int numero = int.Parse(Console.ReadLine());

                Console.WriteLine($"Número digitado: {numero}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Você deve digitar um número inteiro.");
            }
        }
    }
}
