using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_4
{
    public class Email : Mensagem
    {
        public Email(string texto) : base(texto)
        {
        }

        public override void Enviar()
        {
            Console.WriteLine($"Email enviado: {Texto}");
        }
    }
}
