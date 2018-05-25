using System;
using System.Globalization;

namespace S3A1
{
    public class Produto
    {
        string nome;
        public double preco { get; private set; }
        int quantidadeEmEstoque;

        public Produto(string nome, double preco)
        {
            this.nome = nome;
            this.preco = preco;
            this.quantidadeEmEstoque = 0;
        }

        public Produto(string nome, double preco, int quantidade)
        {
            this.nome = nome;
            this.preco = preco;
            this.quantidadeEmEstoque = quantidade;
        }

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
