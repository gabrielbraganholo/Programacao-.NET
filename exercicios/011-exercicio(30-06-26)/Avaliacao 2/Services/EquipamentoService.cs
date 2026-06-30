using Avaliacao_2.Models;

namespace Avaliacao_2.Services
{
    public class EquipamentoService
    {
        private readonly string _caminhoArquivo;

        public EquipamentoService()
        {
            _caminhoArquivo = Path.Combine(
                Directory.GetCurrentDirectory(),
                "Data",
                "equipamentos.txt"
            );

            string? pasta = Path.GetDirectoryName(_caminhoArquivo);

            if (!Directory.Exists(pasta))
                Directory.CreateDirectory(pasta!);

            if (!File.Exists(_caminhoArquivo))
                File.Create(_caminhoArquivo).Close();
        }

        public List<Equipamento> Listar()
        {
            List<Equipamento> equipamentos = new();

            string[] linhas = File.ReadAllLines(_caminhoArquivo);

            foreach (string linha in linhas)
            {
                if (string.IsNullOrWhiteSpace(linha))
                    continue;

                string[] dados = linha.Split(';');

                if (dados.Length < 5)
                    continue;

                if (!int.TryParse(dados[0], out int codigo))
                    continue;

                if (!Enum.TryParse<Situacao>(dados[4], out var situacao))
                    continue;

                equipamentos.Add(new Equipamento
                {
                    Codigo = codigo,
                    Nome = dados[1],
                    Patrimonio = dados[2],
                    Email = dados[3],
                    Situacao = situacao
                });
            }

            return equipamentos;
        }

        public Equipamento? BuscarPorCodigo(int codigo)
        {
            return Listar().FirstOrDefault(e => e.Codigo == codigo);
        }

        public bool CodigoExiste(int codigo)
        {
            return BuscarPorCodigo(codigo) != null;
        }

        public void Adicionar(Equipamento equipamento)
        {
            string linha =
                $"{equipamento.Codigo};" +
                $"{equipamento.Nome};" +
                $"{equipamento.Patrimonio};" +
                $"{equipamento.Email};" +
                $"{equipamento.Situacao}";

            File.AppendAllText(_caminhoArquivo, linha + Environment.NewLine);
        }

        public void Excluir(int codigo)
        {
            List<Equipamento> equipamentos = Listar();

            equipamentos.RemoveAll(e => e.Codigo == codigo);

            List<string> linhas = new();

            foreach (var e in equipamentos)
            {
                linhas.Add(
                    $"{e.Codigo};{e.Nome};{e.Patrimonio};{e.Email};{e.Situacao}"
                );
            }

            File.WriteAllLines(_caminhoArquivo, linhas);
        }
    }
}