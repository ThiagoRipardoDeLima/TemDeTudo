using System;
using System.Globalization;

namespace Cinema.model
{
    class Participacao
    {
        public double desconto { get; private set; }
        public Artista artista { get; private set; }
        public Filme filme { get; private set; }

        public Participacao(double desconto, Artista artista, Filme filme)
        {
            this.desconto   = desconto;
            this.artista    = artista;
            this.filme      = filme;
        }

        public double custo()
        {
            return artista.cache - desconto;
        }

        public override string ToString()
        {
            return artista.nome
                + ", Cachê: "
                + artista.cache.ToString("F2", CultureInfo.InvariantCulture)
                + ", Desconto: "
                + desconto.ToString("F2", CultureInfo.InvariantCulture)
                + ", Custo: "
                + custo().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
