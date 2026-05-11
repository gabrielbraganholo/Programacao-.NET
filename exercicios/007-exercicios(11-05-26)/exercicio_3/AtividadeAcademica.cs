using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_3
{
    abstract class AtividadeAcademica
    {
        private decimal notaMaxima;

        public string Titulo { get; set; }

        public decimal NotaMaxima
        {
            get
            {
                return notaMaxima;
            }
            set
            {
                if (value < 0 || value > 10)
                {
                    throw new InvalidOperationException(
                        "A nota máxima deve respeitar a escala da instituição (0 a 10)"
                    );
                }

                notaMaxima = value;
            }
        }

        public AtividadeAcademica(string titulo, decimal notaMaxima)
        {
            Titulo = titulo;
            NotaMaxima = notaMaxima;
        }

        public abstract decimal CalcularNotaFinal(decimal pontuacaoObtida);
    }
}
