using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_7
{
    public class Livro : ItemBiblioteca
    {
        public Livro(string titulo, string autor) : base(titulo, autor)
        {
        }

        public override void ExibirDestaque()
        {
            Console.WriteLine(Titulo.ToUpper());
        }
    }
}
