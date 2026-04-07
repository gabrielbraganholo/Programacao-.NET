namespace Exercicio_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o comprimento lado do quadrado:");
            double lado = double.Parse(Console.ReadLine());

            Quadrado q = new Quadrado(lado);
            Console.WriteLine($"Área do quadrado: {q.CalcularArea()}");

            Console.WriteLine("Digite o comprimento da base do retângulo:");
            double baseR = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o comprimento da altura do retângulo:");
            double altura = double.Parse(Console.ReadLine());

            Retangulo r = new Retangulo(baseR, altura);
            Console.WriteLine($"Área do retângulo: {r.CalcularArea()}");
        }
    }
}
