using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Notificação_de_Jogos
{
    public abstract class AcaoPersonagem
    {
        public abstract int CustoStamina { get; }
        public abstract void Executar();
    }
}
