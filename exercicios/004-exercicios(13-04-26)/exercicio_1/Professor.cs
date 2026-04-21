using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_1
{
    class Professor : Pessoa
    {
        public string disciplina { get; set; }

        public override string Apresentar()
        {
            return $"disciplina: {disciplina} | nome: {nome} | idade: {idade} anos";
        }

        public override string ExibirTipo()
        {
            return "Sou um professor";
        }
    }
}
