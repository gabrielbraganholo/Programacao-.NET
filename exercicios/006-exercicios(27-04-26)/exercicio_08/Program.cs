namespace exercicio_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria conta = new ContaBancaria(100);

            try
            {
                // saque maior que saldo
                conta.Sacar(1000);
            }
            catch (SaldoInsuficienteException ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
            }

            Console.ReadLine();
        }
    }
}
