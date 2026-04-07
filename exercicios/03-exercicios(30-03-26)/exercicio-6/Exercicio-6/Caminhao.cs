using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_6
{
    public class Caminhao : Veiculo
    {
        public int Eixos { get; set; }

        public Caminhao(int eixos)
        {
            Eixos = eixos;
        }

        public override double CalcularPedagio()
        {
            return 10 * Eixos;
        }
    }
}
