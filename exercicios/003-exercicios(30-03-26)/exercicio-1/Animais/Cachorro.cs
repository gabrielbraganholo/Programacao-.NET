using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animais
{
    public class Cachorro : Animal
    {
        public Cachorro(string nome) : base(nome)
        {
        }

        public override void EmitirSom()
        {
            Console.WriteLine($"{Nome}: Au Au");
        }
    }
}
