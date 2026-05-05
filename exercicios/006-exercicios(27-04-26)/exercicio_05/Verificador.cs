using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_05
{
    internal class Verificador
    {
        public static void VerificarIdade(int idade)
        {
            if (idade < 0 || idade > 150)
            {
                throw new ArgumentOutOfRangeException("idade", "Idade inválida.");
            }
        }
    }
}
