using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_3
{
    internal class Personagem
    {
        public String nome;
        public int vida = 15;
        public int ataque;
        public int posicaoX = 0;
        public int posicaoY = 0;
        public List<string> itensColetados = new List<string>();

        private int opcao = 0;

        public void Movimentar()
        {
            void MostrarPosicao()
            {
                Console.WriteLine("Posição -> X:" + posicaoX+" y:" + posicaoY);
            }

            Console.WriteLine("Digite a direção para movimentar o personagem:\n1 - Frente\n2 - Trás\n3 - Direita\n4 - Esquerda\n5 - Finalizar");
            do
            {
                opcao = int.Parse(Console.ReadLine()!);

                switch (opcao)
                {
                    case 1:
                        posicaoY += 1;
                        MostrarPosicao();
                        break;
                    case 2:
                        posicaoY -= 1;
                        MostrarPosicao();
                        break;
                    case 3:
                        posicaoX -= 1;
                        MostrarPosicao();
                        break;
                    case 4:
                        posicaoX += 1;
                        MostrarPosicao();
                        break;
                    case 5:
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
            } while (opcao != 5);
        }

        public void Atacar()
        {
            Random r = new Random();
            ataque = r.Next(11);

            Console.WriteLine("\nDano do ataque: "+ataque+"\n");
        }

        public void DocumentarItens()
        {
            String item;

            Console.WriteLine("Digite S para sair do loop");
            Console.WriteLine("Digite os itens coletados: ");
            for (int i = 0; true; i++)
            {
                item = Console.ReadLine()!.ToUpper();
                if (item == "S")
                {
                    break;
                }
                else
                {
                    itensColetados.Add(item);    
                }
            }
            for (int i =0; i < itensColetados.Count; i++)
            {
                Console.WriteLine("Item "+(i+1)+": "+itensColetados[i]);
            }
        }

    }
}
