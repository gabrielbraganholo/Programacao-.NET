namespace Avaliacao_2.Models
{
    public class Equipamento
    {
        public int Codigo { get; set; }

        public string Nome { get; set; } = string.Empty;

        public string Patrimonio { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public Situacao Situacao { get; set; }
    }
}