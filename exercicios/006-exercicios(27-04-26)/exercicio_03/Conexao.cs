using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_03
{
    internal class Conexao
    {
        public static void Executar()
        {
            try
            {
                Console.WriteLine("Conexão Aberta");
            }
            finally
            {
                Console.WriteLine("Conexão Fechada");
            }
        }
    }
}
