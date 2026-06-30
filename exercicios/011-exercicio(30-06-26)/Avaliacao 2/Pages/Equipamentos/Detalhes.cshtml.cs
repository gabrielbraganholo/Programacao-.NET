using Avaliacao_2.Models;
using Avaliacao_2.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Avaliacao_2.Pages.Equipamentos
{
    public class DetalhesModel : PageModel
    {
        private readonly EquipamentoService _service;

        public DetalhesModel(EquipamentoService service)
        {
            _service = service;
        }

        public Equipamento? Equipamento { get; set; }

        public IActionResult OnGet(int codigo)
        {
            Equipamento = _service.BuscarPorCodigo(codigo);

            if (Equipamento == null)
                return Page();

            return Page();
        }
    }
}