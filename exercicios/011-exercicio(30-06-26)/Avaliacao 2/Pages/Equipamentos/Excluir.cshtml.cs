using Avaliacao_2.Models;
using Avaliacao_2.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Avaliacao_2.Pages.Equipamentos
{
    public class ExcluirModel : PageModel
    {
        private readonly EquipamentoService _service;

        public ExcluirModel(EquipamentoService service)
        {
            _service = service;
        }

        [BindProperty]
        public Equipamento? Equipamento { get; set; }

        public IActionResult OnGet(int codigo)
        {
            Equipamento = _service.BuscarPorCodigo(codigo);

            if (Equipamento == null)
                return Page();

            return Page();
        }

        public IActionResult OnPost()
        {
            if (Equipamento == null)
                return RedirectToPage("Index");

            _service.Excluir(Equipamento.Codigo);

            TempData["Sucesso"] = "Equipamento excluído com sucesso!";
            return RedirectToPage("Index");
        }
    }
}