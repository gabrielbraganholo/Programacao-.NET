using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_4
{
    public class SMS : Mensagem
    {
        public SMS(string texto) : base(texto)
        {
        }

        public override void Enviar()
        {
            Console.WriteLine($"SMS enviado: {Texto}");
        }
    }
}
