namespace exercicio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool dadosValidos = false;

            while (!dadosValidos)
            {
                try
                {
                    Console.Write("Digite a marca: ");
                    string marca = Console.ReadLine();

                    Console.Write("Digite a quantidade em quilos: ");
                    decimal quantidade = decimal.Parse(Console.ReadLine());

                    Console.Write("Digite o preço por quilo: ");
                    decimal preco = decimal.Parse(Console.ReadLine());

                    EstoqueErva ervaMate = new EstoqueErva(marca, quantidade, preco);

                    Console.WriteLine("\nProduto cadastrado com sucesso.");
                    dadosValidos = true;
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    Console.WriteLine($"\nErro: {ex.Message}\n");
                }
            }
        }
    }
}
