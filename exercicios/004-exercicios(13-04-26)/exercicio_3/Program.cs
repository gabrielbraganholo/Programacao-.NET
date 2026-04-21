namespace exercicio_3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            List<ContaBancaria> contas = new List<ContaBancaria>();

            ContaCorrente cc = new ContaCorrente();
            cc.Depositar(500);
            cc.Sacar(100);

            ContaPoupanca cp = new ContaPoupanca();
            cp.Depositar(300);
            cp.Sacar(50);

            ContaSalario cs = new ContaSalario();
            cs.DepositoEmpresa(1000);
            cs.Sacar(200);

            contas.Add(cc);
            contas.Add(cp);
            contas.Add(cs);

            Console.WriteLine("=== SALDOS ===");

            foreach (ContaBancaria conta in contas)
            {
                conta.ExibirSaldo();
                Console.WriteLine();
            }
        }
    }
}
