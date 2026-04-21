namespace exercicio_4
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            List<Produto> produtos = new List<Produto>();

            Livro livro = new Livro();
            livro.Nome = "Livro de C#";
            livro.Preco = 80;

            Eletronico eletronico = new Eletronico();
            eletronico.Nome = "Teclado";
            eletronico.Preco = 200;

            Roupa roupa1 = new Roupa();
            roupa1.Nome = "Jaqueta";
            roupa1.Preco = 150;

            Roupa roupa2 = new Roupa();
            roupa2.Nome = "Calças";
            roupa2.Preco = 90;

            produtos.Add(livro);
            produtos.Add(eletronico);
            produtos.Add(roupa1);
            produtos.Add(roupa2);
            Console.WriteLine("=== Produtos com desconto ===\n");

            foreach (Produto p in produtos)
            {
                p.ExibirPrecoFinal();
            }
        }
    }
}
