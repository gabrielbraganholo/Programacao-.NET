namespace Sistema_de_Notificação_de_Jogos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<AcaoPersonagem> lista = new List<AcaoPersonagem>();

            while (true)
            {
                Console.WriteLine("------MENU------\n1 - Pular\n2 - Correr\n3 - Sair");
                string opcao = Console.ReadLine();

                if (opcao == "1")
                {
                    AcaoPersonagem acao = new Pular(2);
                    lista.Add(acao);
                }
                else if (opcao == "2")
                {
                    AcaoPersonagem acao = new Correr(10);
                    lista.Add(acao);
                }
                else if (opcao == "3")
                {
                    Console.WriteLine("Ações realizadas:");

                    foreach (var acao in lista)
                    {
                        acao.Executar();
                    }

                    break;
                }
                else
                {
                    Console.WriteLine("Opção inválida");
                }
            }
        }
    }
}