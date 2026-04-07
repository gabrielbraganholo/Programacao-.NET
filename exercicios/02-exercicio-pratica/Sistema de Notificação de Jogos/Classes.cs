using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Notificação_de_Jogos
{
    public class Pular : AcaoPersonagem
    {
        private int altura;

        public Pular(int altura)
        {
            this.altura = altura;
        }

        public override void Executar()
        { 
            Console.WriteLine($"O personagem pulou {altura} metros!");
        }
    }

    public class Correr : AcaoPersonagem
    {
        private int velocidade;

        public Correr(int velocidade)
        {
            this.velocidade = velocidade;
        }

        public override void Executar()
        {
            Console.WriteLine($"O personagem correu a {velocidade} km/h!");
        }
    }
}
