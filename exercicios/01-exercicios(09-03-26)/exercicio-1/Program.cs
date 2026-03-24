namespace exercicio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aluno a = new Aluno();

            Console.WriteLine("Digite o nome do aluno: ");
            a.nome = Console.ReadLine();
            Console.WriteLine("Digite o curso do aluno: ");
            a.curso = Console.ReadLine();
            Console.WriteLine("Digite o número de matrícula do aluno: ");
            a.numeroMatricula = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a nota 1: ");
            a.n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a nota 2: ");
            a.n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a nota 3: ");
            a.n3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Nome do aluno: "+a.nome+"\nCurso: "+a.curso+"\nNúmero de matricula: "+a.numeroMatricula);

            a.CalcularMedia();
        }
    }
}
