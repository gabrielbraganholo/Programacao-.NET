using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_02
{
    internal class Divisao
    {
        public static void Executar()
        {
            try
            {
                Console.Write("Digite o primeiro número: ");
                int a = int.Parse(Console.ReadLine());

                Console.Write("Digite o segundo número: ");
                int b = int.Parse(Console.ReadLine());

                int resultado = a / b;

                Console.WriteLine($"Resultado: {resultado}");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Não existe divisão por zero");
            }
        }
    }
}
