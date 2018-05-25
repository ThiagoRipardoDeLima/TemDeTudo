using System;

namespace S3E2
{
    class Quarto
    {
        public string nome { get; private set; }
        public string email { get; private set; }

        public Quarto(string nome, string email)
        {
            this.nome = nome;
            this.email = email;
        }

        public override string ToString()
        {
            return nome + ", " + email;
        }

    }
}
