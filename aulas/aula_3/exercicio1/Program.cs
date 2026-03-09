namespace exercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Jogo j = new Jogo();
            Console.WriteLine("Título do jogo: ");
            j.titulo = Console.ReadLine();
            Console.WriteLine("Gênero do jogo: ");
            j.genero = Console.ReadLine();
            Console.WriteLine("Plataforma do jogo: ");
            j.plataforma = Console.ReadLine();
            Console.WriteLine("Ano de lançamento do jogo: ");
            j.anoDeLancamento = int.Parse(Console.ReadLine());

            Console.WriteLine("Título: " + j.titulo);
            Console.WriteLine("Gênero: " + j.genero);
            Console.WriteLine("Plataforma: " + j.plataforma);
            Console.WriteLine("Ano de lançamento: " + j.anoDeLancamento);

        }
    }
}
