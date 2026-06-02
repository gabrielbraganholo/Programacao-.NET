using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Exercicio.Pages
{
    public class VerificadorAcessoModel : PageModel
    {
        [BindProperty]
        public string Nome { get; set; }

        [BindProperty]
        public int? Idade { get; set; }

        public string MensagemDeRetorno { get; set; }

        public void OnPost()
        {
            if (Idade.HasValue && Idade.Value  >= 18)
            {
                MensagemDeRetorno = $"Olá, {Nome}! Entrada Liberada.";
            }
            else
            {
                MensagemDeRetorno = $"Olá, {Nome}! Entrada Bloqueada para menores.";
            }
        }
    }
}
