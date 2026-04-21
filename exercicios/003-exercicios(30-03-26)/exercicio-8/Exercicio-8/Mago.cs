using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_8
{
    public class Mago : Personagem
    {
        public override void Atacar()
        {
            Console.WriteLine("Mago atacou com magia");
        }
    }
}
