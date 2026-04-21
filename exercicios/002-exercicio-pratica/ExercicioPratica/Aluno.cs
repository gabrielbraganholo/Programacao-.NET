using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioPratica
{
    internal class Aluno
    {
        public string nome;
        public int nota; // entra 0 e 10, tem que ser validada para aceitar apenas esses valores
        private int matricula; // pode ser lida por qualquer um, mas só pode ser definida dentro da classe

        public int Matricula
        {
            get { return matricula; }
            set { matricula = value; }
        }

        public int ValidarNota()
        {
            while (true)
            {
                Console.WriteLine("Digite sua nota: ");
                if (int.TryParse(Console.ReadLine(), out nota))
                {
                    if (nota >= 0 && nota <= 10)
                    {
                        return nota;
                        break;
                    }
                }
                Console.WriteLine("Valor inválido. Apenas inteiros de 0 a 10 são permitidos.");
            }
        }
    }
}
