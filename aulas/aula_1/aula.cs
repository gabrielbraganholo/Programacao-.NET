using System.Collections;

namespace PrimeiroProjetoC_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!\n");
            //Console.WriteLine("Olá, Mundo!");

            int n1, n2;
            double d;
            float f;
            string nome;
            decimal preco; //sugerido utilizar pq faz a soma direta no número
            String sobrenome;

            n1 = 2;
            n2 = 3;
            d = 4.33;
            f = 5.44f; //precisa do "f" no final para funcionar com o float (melhor usar double)
            preco = 6.55m; // mesmo caso do double só que com um "m"

            nome = "Gabriel";
            sobrenome = "Braganholo";
            string nomeCompleto = nome + " " + sobrenome;

            Console.WriteLine("Inteiros: " + n1 + "|" + n2);
            //Console.WriteLine("Double: " + d); //(concatenação)
            Console.WriteLine($"Double: {d}"); //funciona como o .format do python (interpolação)
            Console.WriteLine("Float: " + f);
            Console.WriteLine("Decimal: " + preco);
            Console.WriteLine("Nome completo: " + nomeCompleto + "\n");

            //DateTime data = new DateTime();
            DateTime data = DateTime.Now;
            Console.WriteLine("Dia: "+data.Day);
            Console.WriteLine("Dia da semana: "+data.DayOfWeek);
            Console.WriteLine("Mes: "+data.Month);
            Console.WriteLine("Ano: "+data.Year);
            Console.WriteLine("Hora: "+data.Hour);
            Console.WriteLine("Minuto: "+data.Minute);
            Console.WriteLine("Data completa: "+data +"\n");

            string disciplina;
            string curso;

            Console.WriteLine("Digite o nome do curso: ");
            curso = Console.ReadLine();
            Console.WriteLine("Digite o nome da disciplina: ");
            disciplina = Console.ReadLine();

            Console.WriteLine("\n" +$"Curso: {curso}");
            Console.WriteLine($"Disciplina: {disciplina}");
        }
    }
}
