using System;
using System.Globalization;

namespace S2A2
{
    class Produto
    {
        public string nome;
        public double preco;
        public int quantidadeEmEstoque;

        public double valorTotalEmEstoque()
        {
            return preco * quantidadeEmEstoque;
        }

        public void realizaEntrada(int quantidade)
        {
            this.quantidadeEmEstoque += quantidade;
        }

        public void realizaSaida(int quantidade)
        {
             this.quantidadeEmEstoque -= quantidade;
        }

        public override string ToString()
        {
            return nome
                + ", R$ "
                + preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + quantidadeEmEstoque
                + " unidade(s)";
        }
    }
}
