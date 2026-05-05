using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_06
{
    internal class ListaCidade
    {
        public static void Executar()
        {
            List<string> cidades = new List<string> { "Santa Maria", "Tupaciereta", "Agudo" };

            try
            {
                Console.Write("Digite um índice: ");
                int indice = int.Parse(Console.ReadLine());

                Console.WriteLine(cidades[indice]);
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Índices válidos: 0 a 2");
            }
        }
    }
}
