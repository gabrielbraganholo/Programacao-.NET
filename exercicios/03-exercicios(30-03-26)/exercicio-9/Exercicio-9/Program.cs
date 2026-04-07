namespace Exercicio_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Carrinho carrinho = new Carrinho();

            carrinho.lista.Add(new ProdutoNacional(50));
            carrinho.lista.Add(new ProdutoImportado(50));
            carrinho.lista.Add(new ProdutoNacional(30));
            carrinho.lista.Add(new ProdutoImportado(100));

            foreach (var produto in carrinho.lista)
            {
                Console.WriteLine(produto.CalcularPreco());
            }

            Console.WriteLine($"Total da compra: {carrinho.Total()}");
        }
    }
}
