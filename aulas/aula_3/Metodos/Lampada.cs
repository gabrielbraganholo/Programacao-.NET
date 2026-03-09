using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos
{
    internal class Lampada
    {
        public bool ligada;
        public double potencia;

        public void Ligar()
        {
            if (ligada)
            {
                Console.WriteLine("Lâmpada já está ligada.");
            }
            else
            {
                ligada = true;
                Console.WriteLine("Lâmpada ligada.");
            }
            
        }

        public void Desligar()
        {
            if (EstaLigada()) // outro jeito de  fazer a mesma coisa: if (ligada)
            {
                ligada = false;
                Console.WriteLine("Lâmpada desligada.");
            }
            else
            {
                Console.WriteLine("Lâmpada já está desligada.");
            }
        }

        public bool EstaLigada()
        {
            return ligada;
        }
    }
}
