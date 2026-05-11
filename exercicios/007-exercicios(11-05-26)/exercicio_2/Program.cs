namespace exercicio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PecaAcabamento peca = new PecaAcabamento("LED123", 120, " 12Azul", 12);

            decimal precoVenda = peca.CalcularPrecoVenda(30);

            Console.WriteLine($"Preço de venda: {precoVenda}");

            // Console.WriteLine(peca.codigoPeca);
            // ERRO: codigoPeca é protected

            // Console.WriteLine(peca.custoFabricacao);
            // ERRO: custoFabricacao é protected
        }
    }
}
