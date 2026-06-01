using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Exercicio.Pages
{
    public class SociosModel : PageModel
    {
        private readonly IConfiguration _configuration;

        public List<Sociotorcedor> Socios { get; set; }

        public SociosModel(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public void OnGet()
        {
            Socios = new List<Sociotorcedor>
            {
                new Sociotorcedor(_configuration, "João", "Ouro", -2, 100.0m),
                new Sociotorcedor(_configuration, "Maria", "Prata", 25, 50.0m),
                new Sociotorcedor(_configuration, "Pedro", "Bronze", 12, 20.0m),
                new Sociotorcedor(_configuration, "Ana", "Ouro", 30, 15.0m)
            };
        }
    }

    public class Sociotorcedor
    {
        private readonly IConfiguration _configuration;

        public string Nome { get; set; }

        private string _categoria;

        public string Categoria
        {
            get
            {
                return _categoria;
            }

            set
            {
                if (value != "Ouro" && value != "Prata" && value != "Bronze")
                {
                    throw new ArgumentException("Categoria inválida");
                }

                _categoria = value;
            }
        }

        private int _idade;

        public int Idade
        {
            get { return _idade; }
            set
            {
                int idadeMinima = _configuration.GetValue<int>("ValoresMinimos:IdadeMinima");

                if (value < idadeMinima)
                {
                    _idade = idadeMinima;
                }
                else
                {
                    _idade = value;
                }
            }
        }

        private decimal _mensalidade;
        public decimal Mensalidade
        {
            get { return _mensalidade; }
            set
            {
                decimal mensalidadeMinima = _configuration.GetValue<decimal>("ValoresMinimos:MensalidadeMinima");

                if (value < mensalidadeMinima)
                {
                    _mensalidade = mensalidadeMinima;
                }
                else
                {
                    _mensalidade = value;
                }
            }
        }
        public Sociotorcedor(IConfiguration configuration, string nome, string categoria, int idade, decimal mensalidade)
        {
            _configuration = configuration;

            Nome = nome;
            Categoria = categoria;
            Idade = idade;
            Mensalidade = mensalidade;
        }
    }
}
