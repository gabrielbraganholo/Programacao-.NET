using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_2
{
    public class HomeTheater : AparelhoSom
    {
        public override void AumentarVolume()
        {
            volume += 5;
            Console.WriteLine($"Home Theater volume: {volume}");
        }
    }
}
