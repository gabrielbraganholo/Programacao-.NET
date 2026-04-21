namespace Exercicio_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Funcionario> lista = new List<Funcionario>();

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("1 - Vendedor");
                Console.WriteLine("2 - Gerente");

                string op = Console.ReadLine();

                Console.WriteLine("Salário base:");
                double salario = double.Parse(Console.ReadLine());

                if (op == "1")
                {
                    Console.WriteLine("Vendas:");
                    double vendas = double.Parse(Console.ReadLine());
                    lista.Add(new Vendedor(salario, vendas));
                }
                else
                {
                    Console.WriteLine("Bonus:");
                    double bonus = double.Parse(Console.ReadLine());
                    lista.Add(new Gerente(salario, bonus));
                }
            }

            foreach (var f in lista)
            {
                double pagamento = f.CalcularPagamento();

                Console.WriteLine($"Pagamento: {pagamento}");

                if (pagamento > 5000)
                {
                    Console.WriteLine("Alerta de Orçamento!");
                }
            }
        }
    }
}
