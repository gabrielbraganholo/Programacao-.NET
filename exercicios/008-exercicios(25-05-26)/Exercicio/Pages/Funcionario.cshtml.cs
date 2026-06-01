using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Exercicio.Pages
{
    public class FuncionarioModel : PageModel
    {
        public List<Funcionario> Funcionarios { get; set; }
        public void OnGet()
        {
            Funcionarios = new List<Funcionario>
            {
                new Funcionario("João", "Desenvolvedor", 5000),
                new Funcionario("Maria", "Analista de Sistemas", 4500),
                new Funcionario("Carlos", "Gerente de Projetos", 7000)
            };
        }
    }
}

public class Funcionario
{
    public string Nome { get; set; }
    public string Cargo { get; set; }
    public decimal Salario { get; set; }

    public Funcionario(string nome, string cargo, decimal salario)
    {
        Nome = nome;
        Cargo = cargo;
        Salario = salario;
    }
}