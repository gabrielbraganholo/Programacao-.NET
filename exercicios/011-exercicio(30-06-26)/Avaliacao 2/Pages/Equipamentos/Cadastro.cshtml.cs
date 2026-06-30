using Avaliacao_2.Models;
using Avaliacao_2.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Avaliacao_2.Pages.Equipamentos
{
    public class CadastroModel : PageModel
    {
        private readonly EquipamentoService _service;

        public CadastroModel(EquipamentoService service)
        {
            _service = service;
        }

        [BindProperty]
        public Equipamento Equipamento { get; set; } = new();

        public List<SelectListItem> Situacoes { get; set; } = new();

        public void OnGet()
        {
            Situacoes = Enum.GetValues(typeof(Situacao))
                .Cast<Situacao>()
                .Select(s => new SelectListItem
                {
                    Value = s.ToString(),
                    Text = s.ToString()
                }).ToList();
        }

        public IActionResult OnPost()
        {
            _service.Adicionar(Equipamento);
            return RedirectToPage("Index");
        }
    }
}