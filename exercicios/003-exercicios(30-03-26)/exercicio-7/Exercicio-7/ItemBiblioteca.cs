using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_7
{
    public abstract class ItemBiblioteca
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }

        public ItemBiblioteca(string titulo, string autor)
        {
            Titulo = titulo;
            Autor = autor;
        }

        public abstract void ExibirDestaque();
    }
}
