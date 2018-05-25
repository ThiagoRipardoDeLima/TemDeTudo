using System;
using System.Collections.Generic;
using System.Globalization;

namespace Cinema.model
{
    class Filme
    {
        public int codigo { get; private set; }
        public string titulo { get; private set; }
        public int ano { get; private set; }
        public List<Participacao> participantes { get; private set; }

        public Filme(int codigo, string titulo, int ano)
        {
            this.codigo = codigo;
            this.titulo = titulo;
            this.ano = ano;
            participantes = new List<Participacao>();
        }

        public void adicionaParticipante(Participacao ator)
        {
            participantes.Add(ator);
        }

        public double custoTotal()
        {
            double total = 0.00;
            foreach (Participacao ator in participantes)
                total += ator.custo();

            return total;
        }

        public string imprimeParticipantes()
        {
            string atores = "";
            foreach (Participacao ator in participantes)
                atores += ator + "\n";

            return atores;
        }

        public override string ToString()
        {
            return "Filme: " + codigo + ", Título: " + titulo + ", Ano: " + ano + "\n"
                + "Participações: \n"
                + imprimeParticipantes()
                + "Custo total do filme: " + custoTotal().ToString("F2", CultureInfo.InvariantCulture);
        }


    }
}
