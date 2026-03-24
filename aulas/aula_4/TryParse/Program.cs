namespace TryParse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa p = new Pessoa();

            while (true)
            {
                Console.WriteLine("Digite seu cpf: ");
                if (int.TryParse(Console.ReadLine(), out p.cpf))
                {
                    break;
                }
                Console.WriteLine("Cpf inválido. Digite apenas números.");
            }

            Console.WriteLine("CPF registrado: "+p.cpf);
        }
    }
}
