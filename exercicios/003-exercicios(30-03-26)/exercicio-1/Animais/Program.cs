namespace Animais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Animal> lista = new List<Animal>();

            lista.Add(new Cachorro("Nina"));
            lista.Add(new Gato("Pipoca"));

            foreach (var animal in lista)
            {
                animal.EmitirSom();
            }
        }
    }
}
