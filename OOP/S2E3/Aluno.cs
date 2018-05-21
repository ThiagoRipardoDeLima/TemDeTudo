using System;
using System.Globalization;

namespace S2E3
{
    class Aluno
    {
        private string nome;
        private Notas nota;
        
        public string Nome { get => nome; set => nome = value; }
        internal Notas Nota { get => nota; set => nota = value; }

        public Aluno() => nota = new Notas();

        public double Media()
        {
            return (Nota.N1 + Nota.N2 + Nota.N3) / 3;
        }

        public double NotaFinal()
        {
            return Nota.N1 + Nota.N2 + Nota.N3;
        }

        public double NotaMinimaAprovacao()
        {
            return (Constantes.NotaT1 + Constantes.NotaT2 + Constantes.NotaT3) * 0.6;
        }

        public string StatusAprovacao()
        {
            return Mensagem(NotaFinal() >= NotaMinimaAprovacao());
        }

        public string Mensagem(Boolean status)
        {
            return status ? "APROVADO" 
                            : "REPROVADO \n" 
                                + "FALTARAM " 
                                + (NotaMinimaAprovacao() - NotaFinal()).ToString("F2")
                                + " PONTOS";
        }


        public override string ToString()
        {
            return "Aluno: "
                + Nome + "\n"
                + "Nota Final: "
                + NotaFinal().ToString("F2", CultureInfo.InvariantCulture) + " \n"
                + StatusAprovacao();
                
        }

    }
}
