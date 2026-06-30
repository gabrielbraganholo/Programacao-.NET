using Avaliacao_2.Models;
using Avaliacao_2.Services;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Avaliacao_2.Pages.Equipamentos
{
    public class IndexModel : PageModel
    {
        private readonly EquipamentoService _service;

        public List<Equipamento> Equipamentos { get; set; } = new();

        public IndexModel(EquipamentoService service)
        {
            _service = service;
        }

        public void OnGet()
        {
            Equipamentos = _service.Listar();
        }
    }
}