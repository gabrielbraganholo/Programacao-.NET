namespace exercicio_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Verificador.VerificarIdade(-1);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
