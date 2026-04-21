using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_1
{
    abstract class Pessoa
    {
        public string nome { get; set; }
        public int idade { get; set; }

        public abstract string Apresentar();

        public abstract string ExibirTipo();
    }
}
