namespace ExercicioPratica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aluno a = new Aluno();
            Console.WriteLine("Digite o nome do aluno: ");
            a.nome = Console.ReadLine();
            a.nota = a.ValidarNota();
            Console.WriteLine("Digite a sua matrícula: ");
            a.Matricula = int.Parse(Console.ReadLine());

            Console.WriteLine(a.nome);
            Console.WriteLine(a.nota);
            Console.WriteLine(a.Matricula);
        }
    }
}
