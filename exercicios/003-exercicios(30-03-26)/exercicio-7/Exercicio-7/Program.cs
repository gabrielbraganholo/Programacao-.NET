namespace Exercicio_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<ItemBiblioteca> lista = new List<ItemBiblioteca>();

            lista.Add(new Livro("Dom Casmurro", "Machado de Assis"));
            lista.Add(new Revista("Placar", "Editora Abril", 150));
            lista.Add(new Livro("O Hobbit", "Tolkien"));
            lista.Add(new Revista("National Geographic", "National Geographic", 45));

            foreach (var item in lista)
            {
                item.ExibirDestaque();
            }
        }
    }
}
