namespace Exercicio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<AparelhoSom> lista = new List<AparelhoSom>();

            lista.Add(new Radio());
            lista.Add(new HomeTheater());

            for (int i = 0; i < 2; i++)
            {
                foreach (var item in lista)
                {
                    item.AumentarVolume();
                }
            }
        }
    }
}
