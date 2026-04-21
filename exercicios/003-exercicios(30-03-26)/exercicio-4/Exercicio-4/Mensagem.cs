using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_4
{
    public abstract class Mensagem
    {
        public string Texto { get; set; }

        public Mensagem(string texto)
        {
            Texto = texto;
        }

        public abstract void Enviar();
    }
}
