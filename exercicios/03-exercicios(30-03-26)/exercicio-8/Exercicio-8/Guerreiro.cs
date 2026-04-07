using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_8
{
    public class Guerreiro : Personagem
    {
        public override void Atacar()
        {
            Console.WriteLine("Guerreiro atacou com espada");
        }
    }
}
