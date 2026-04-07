namespace Exercicio_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Veiculo> lista = new List<Veiculo>();
            string opcao;

            do
            {
                Console.WriteLine("1 - Carro\n2 - Caminhão\n3 - Sair");

                opcao = Console.ReadLine();

                if (opcao == "1")
                {
                    lista.Add(new Carro());
                }
                else if (opcao == "2")
                {
                    Console.WriteLine("Quantidade de eixos: ");
                    int eixos = int.Parse(Console.ReadLine());
                    lista.Add(new Caminhao(eixos));
                }

            } while (opcao != "3");

            double total = 0;

            foreach (var v in lista)
            {
                total += v.CalcularPedagio();
            }

            Console.WriteLine($"Total arrecadado: {total}");
        }
    }
}
