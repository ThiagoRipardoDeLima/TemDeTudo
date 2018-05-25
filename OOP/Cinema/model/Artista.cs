using System;
using System.Globalization;

namespace Cinema.model
{
    class Artista : IComparable
    {
        public int codigo { get; private set; }
        public string nome { get; private set; }
        public double cache { get; private set; }

        public Artista(int codigo, string nome, double cache)
        {
            this.codigo = codigo;
            this.nome = nome;
            this.cache = cache;
        }

        public override string ToString()
        {
            return codigo
                + ", "
                + nome
                + ", Cachê: "
                + cache.ToString("F2", CultureInfo.InvariantCulture);
        }

        public int CompareTo(object obj)
        {
            Artista artista = (Artista)obj;
            int resultado = nome.CompareTo(artista.nome);
            if (resultado != 0)
                return resultado;

            return 0;
        }
      
    }
}
