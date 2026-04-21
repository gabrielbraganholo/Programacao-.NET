namespace Exercicio_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Personagem> lista = new List<Personagem>();

            Random random = new Random();

            for (int i = 0; i < 3; i++)
            {
                if (random.Next(2) == 0)
                    lista.Add(new Guerreiro());
                else
                    lista.Add(new Mago());
            }

            foreach (var p in lista)
            {
                p.Atacar();
            }
        }
    }
}
