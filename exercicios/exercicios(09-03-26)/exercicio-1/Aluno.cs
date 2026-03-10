using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_1
{
    internal class Aluno
    {
        public String nome;
        public String curso;
        public int numeroMatricula;

        public int n1;
        public int n2;
        public int n3;

        private int media;
        public void CalcularMedia()
        {
            media = (n1+n2+n3)/3;

            Console.WriteLine("Média: "+media);

            if (media >= 7)
            {
                Console.WriteLine("Aprovado.");
            }
            else
            {
                Console.WriteLine("Reprovado.");
            }
        }
    }
}
