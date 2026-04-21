using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_1
{
    class Funcionario : Pessoa
    {
        public string cargo { get; set; }

        public override string Apresentar()
        {
            return "Sou um funcionário";
        }

        public override string ExibirTipo()
        {
            return $"cargo: {cargo} | nome: {nome} | idade: {idade} anos";
        }
    }
}
