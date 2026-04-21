using System.Security.Cryptography;

namespace exercicio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Veiculo> v = new List<Veiculo>();

            v.Add(new Carro
            {
                Marca = "Toyota",
                Modelo = "Corolla",
                Portas = 3,
                KmRodados = 500,
                LitrosConsumidos = 40
            });
            v.Add(new Moto
            {
                Marca = "Honda",
                Modelo = "CB500",
                Cilindradas = 500
            });

            foreach (var veiculo in v)
            {
                veiculo.Dirigir();
                Console.WriteLine(veiculo.CalcularConsumo());
                Console.WriteLine("---------------------------------------------------");

            }
        }
    }
}
