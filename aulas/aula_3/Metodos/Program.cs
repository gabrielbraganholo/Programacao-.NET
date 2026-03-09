namespace Metodos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lampada l1 = new Lampada();
            l1.potencia = 200;
            l1.Ligar();
            l1.Desligar();

            bool b = l1.EstaLigada();
            Console.WriteLine("Retorno do EstaLigada: "+b);
            l1.Ligar();
            b = l1.EstaLigada();
            Console.WriteLine("Retorno do EstaLigada: " + b);
            l1.Ligar();
        }
    }
}
