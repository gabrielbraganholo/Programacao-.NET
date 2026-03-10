namespace exercicio_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Personagem p = new Personagem();
            Console.WriteLine("Digite o nome do personagem:");
            p.nome = Console.ReadLine();
            p.DocumentarItens();

            Console.WriteLine("Vida: "+p.vida);

            p.Movimentar();
            p.Atacar();
        }
    }
}
