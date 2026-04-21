using System.Security.Cryptography;

namespace exercicio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Pessoa> p = new List<Pessoa>();

            p.Add(new Aluno
            {
                nome = "João",
                idade = 20,
                matricula = "123456"
            });
            p.Add(new Professor
            {
                nome = "Fábio",
                idade = 35,
                disciplina = "Matemática"
            });
            p.Add(new Funcionario
            {
                nome = "Cláudio",
                idade = 40,
                cargo = "Secretário"
            });

            foreach (var item in p)
            {
                Console.WriteLine(item.Apresentar());
                Console.WriteLine(item.ExibirTipo());
                Console.WriteLine();
            }
        }
    }
}
