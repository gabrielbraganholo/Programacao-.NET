using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_2
{
    internal class Livro
    {
        public bool emprestado = false;
        public String titulo;
        public String dataDeLancamento;
        public String autor;

        private int inicial = 1;

        public void Emprestar()
        {
            if (emprestado)
            {
                Console.WriteLine("O livro "+titulo+" ainda não foi devolvido.");
            }
            else
            {
                Console.WriteLine("Emprestado.");
                emprestado = true;
            }
        }

        public void Devolver()
        {
            if ((!emprestado) && (inicial != 1))
            {
                Console.WriteLine("O livro "+titulo+" já foi devolvido.");
            }
            else if (inicial != 1)
            {
                Console.WriteLine("Devolvido.");
                emprestado = false;
            }
            if (inicial == 1)
            {
                Console.WriteLine("O livro " + titulo + " ainda não foi emprestado.");
                inicial = 0;
            }
        }
    }
}
