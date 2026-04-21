using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_2
{
    public class Moto : Veiculo
    {
        public int Cilindradas { get; set; }

        public override void Dirigir()
        {
            Console.WriteLine($"Dirigindo a {Marca} {Modelo} com {Cilindradas} cilindradas.");
        }

        public override string CalcularConsumo()
        {
            if (Cilindradas <= 150)
            {
                return "Consumo estimado: 30 km/l";
            }
            else if (Cilindradas <= 250)
            {
                return "Consumo estimado: 25 km/l";
            }
            else
            {
                return "Consumo estimado: 20 km/l";
            }
        }
    }
}
