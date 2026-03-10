namespace exercicio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Livro l1 = new Livro();
            Console.WriteLine("Digite o título do livro: ");
            l1.titulo = Console.ReadLine();
            System.Console.WriteLine("Digite a data de lançamento: ");
            l1.dataDeLancamento = Console.ReadLine();
            System.Console.WriteLine("Digite o nome do autor: ");
            l1.autor = Console.ReadLine();

            Livro l2 = new Livro();
            System.Console.WriteLine("Digite o título do livro: ");
            l2.titulo = Console.ReadLine();
            System.Console.WriteLine("Digite a data de lançamento: ");
            l2.dataDeLancamento = Console.ReadLine();
            System.Console.WriteLine("Digite o nome do autor: ");
            l2.autor = Console.ReadLine();

            l1.Devolver();
            l1.Emprestar();
            l1.Emprestar();
            l1.Devolver();
            l1.Devolver();
        }
    }
}
