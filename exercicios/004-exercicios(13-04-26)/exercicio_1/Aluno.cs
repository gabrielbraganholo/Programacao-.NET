using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_1
{
    class Aluno : Pessoa
    {

        public string matricula { get; set; }

        public override string Apresentar()
        {
            return $"id: {matricula} | nome: {nome} | idade: {idade} anos";
        }

        public override string ExibirTipo()
        {
            return "Sou um aluno";
        }
    }
}
