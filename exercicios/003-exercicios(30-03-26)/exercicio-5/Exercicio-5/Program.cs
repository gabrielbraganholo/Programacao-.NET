namespace Exercicio_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Conta c1 = new ContaCorrente(100);
            Conta c2 = new ContaPoupanca(100);

            c1.Sacar(20);
            c2.Sacar(20);

            c1.MostrarSaldo();
            c2.MostrarSaldo();

            c1.Sacar(120);
            c2.Sacar(120);
        }
    }
}
