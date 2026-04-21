using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_2
{
    public class Radio : AparelhoSom
    {
        public override void AumentarVolume()
        {
            volume += 1;
            Console.WriteLine($"Volume do Rádio: {volume}");
        }
    }
}
