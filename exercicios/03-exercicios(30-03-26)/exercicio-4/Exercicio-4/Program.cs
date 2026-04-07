namespace Exercicio_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Mensagem> lista = new List<Mensagem>();

            lista.Add(new Email("Teste email"));
            lista.Add(new SMS("Teste SMS"));

            foreach (var msg in lista)
            {
                msg.Enviar();
            }
        }
    }
}
