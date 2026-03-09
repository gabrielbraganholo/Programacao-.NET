namespace exercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Estudio e = new Estudio();
            Console.WriteLine("Digite o nome do estúdio: ");
            e.nome = Console.ReadLine();
            Console.WriteLine("Digite o ano de fundação do estúdio: ");
            e.anoDeFundacao = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o país de origem do estúdio: ");
            e.paisDeOrigem = Console.ReadLine();
            Console.WriteLine("Digite o número de jogos lançados pelo estúdio: ");
            e.numeroDeJogosLancados = int.Parse(Console.ReadLine());

            Console.WriteLine("Nome do estúdio: " + e.nome);
            Console.WriteLine("Ano de fundação do estúdio: " + e.anoDeFundacao);
            Console.WriteLine("País de origem do estúdio: " + e.paisDeOrigem);
            Console.WriteLine("Número de jogos lançados pelo estúdio: " + e.numeroDeJogosLancados);
        }
    }
}
