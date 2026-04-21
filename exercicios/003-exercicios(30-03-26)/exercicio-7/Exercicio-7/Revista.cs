using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_7
{
    public class Revista : ItemBiblioteca
    {
        public int Edicao { get; set; }

        public Revista(string titulo, string autor, int edicao) : base(titulo, autor)
        {
            Edicao = edicao;
        }

        public override void ExibirDestaque()
        {
            Console.WriteLine($"{Titulo} - Edição {Edicao}");
        }
    }
}
