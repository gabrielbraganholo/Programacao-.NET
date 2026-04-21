using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_2
{
    public class Carro : Veiculo
    {
        public double KmRodados { get; set; }
        public double LitrosConsumidos { get; set; }

        private int portas;
        public int Portas
        {
            get { return portas; }
            set
            {
                if (value == 2 || value == 3 || value == 5)
                {
                    portas = value;
                }
                else
                {
                    throw new ArgumentException("O número de portas deve ser 2, 3 ou 5.");
                }
            }
        }

        public override void Dirigir()
        {
            Console.WriteLine($"Dirigindo o {Marca} {Modelo} com {portas} portas.");
        }

        public override string CalcularConsumo()
        {
            double consumo = KmRodados / LitrosConsumidos;

            return $"Consumo estimado: {consumo:F2} km/l";
        }
    }
}
