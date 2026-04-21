using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_3
{
    public class Retangulo : Forma
    {
        private double baseR;
        private double altura;

        public Retangulo(double baseR, double altura)
        {
            this.baseR = baseR;
            this.altura = altura;
        }

        public override double CalcularArea()
        {
            return baseR * altura;
        }
    }
}
