using Avaliacao_2.Models;
using Avaliacao_2.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Avaliacao_2.Pages.Equipamentos
{
    public class EditarModel : PageModel
    {
        private readonly EquipamentoService _service;

        public EditarModel(EquipamentoService service)
        {
            _service = service;
        }

        [BindProperty]
        public Equipamento? Equipamento { get; set; }

        public List<SelectListItem> Situacoes { get; set; } = new();

        public IActionResult OnGet(int codigo)
        {
            Equipamento = _service.BuscarPorCodigo(codigo);

            if (Equipamento == null)
                return RedirectToPage("Index");

            CarregarSituacoes();
            return Page();
        }

        public IActionResult OnPost()
        {
            if (Equipamento == null)
                return RedirectToPage("Index");

            if (string.IsNullOrWhiteSpace(Equipamento.Nome) || Equipamento.Nome.Length < 3)
                ModelState.AddModelError("", "Nome inválido");

            if (Equipamento.Nome.Contains(";"))
                ModelState.AddModelError("", "Nome inválido");

            if (string.IsNullOrWhiteSpace(Equipamento.Patrimonio) || Equipamento.Patrimonio.Length < 6)
                ModelState.AddModelError("", "Patrimônio inválido");

            if (string.IsNullOrWhiteSpace(Equipamento.Email) || !Equipamento.Email.Contains("@"))
                ModelState.AddModelError("", "Email inválido");

            if (!ModelState.IsValid)
            {
                CarregarSituacoes();
                return Page();
            }

            _service.Excluir(Equipamento.Codigo);
            _service.Adicionar(Equipamento);

            TempData["Sucesso"] = "Equipamento atualizado com sucesso!";
            return RedirectToPage("Index");
        }

        private void CarregarSituacoes()
        {
            Situacoes = Enum.GetValues(typeof(Situacao))
                .Cast<Situacao>()
                .Select(s => new SelectListItem
                {
                    Value = s.ToString(),
                    Text = s.ToString()
                }).ToList();
        }
    }
}