namespace exercicio_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<AtividadeAcademica> atividades = new List<AtividadeAcademica>();

            try
            {
                atividades.Add(new ProvaObjetiva("Prova de POO", 10));
                atividades.Add(new ProjetoPratico("Projeto Final", 10));

                atividades.Add(new ProvaObjetiva("Atividade Inválida", 15));
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine();

            foreach (AtividadeAcademica atividade in atividades)
            {
                decimal notaFinal = atividade.CalcularNotaFinal(7);

                Console.WriteLine($"Atividade: {atividade.Titulo}");
                Console.WriteLine($"Nota final: {notaFinal}\n");
            }
        }
    }
}
