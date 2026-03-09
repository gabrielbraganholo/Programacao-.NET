namespace primeiroOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá!");
            Pessoa p1 = new Pessoa(); // instanciando um novo objeto do tipo Pessoa
            p1.nome = "Kichan";
            p1.idade = 20;
            Console.WriteLine("Nome: "+p1.nome);
            Console.WriteLine("Idade: "+p1.idade);

            Pessoa p2 = new Pessoa();
            Console.WriteLine("Digite seu nome: ");
            p2.nome = Console.ReadLine();
            Console.WriteLine("Digite sua idade: ");
            p2.idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Nome: "+p2.nome +" || Idade: "+p2.idade);

            Pessoa p3 = new Pessoa();
            Console.WriteLine("Digite seu nome: ");
            p3.nome = Console.ReadLine();
            Console.WriteLine("Digite sua idade: ");
            p3.idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Nome: " + p3.nome +" || Idade: " + p3.idade);

            Professor prof = new Professor();
            prof.nome = "Ricardo da Silva";
            Laboratorio lab = new Laboratorio();
            lab.local = "Sala 108";
            Console.WriteLine("Nome do professor: "+prof.nome + " || Local: "+lab.local); 
        }
    }
}
