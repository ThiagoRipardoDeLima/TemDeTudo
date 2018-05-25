using System;
using System.Globalization;

namespace S3A1
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto P;

            Console.WriteLine("Digite os dados do Produto:");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            P = new Produto(nome, preco);

            //Console.Write("Quantidade em estoque: ");
            //int quantidadeEmEstoque = int.Parse(Console.ReadLine());

            //P = new Produto(nome, preco, quantidadeEmEstoque);

            Console.WriteLine("Dados do produto: " + P + ", Total: R$ " + P.valorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture));

            Console.Write("Digite a quantidade de produtos que entraram no estoque: ");
            P.realizaEntrada(int.Parse(Console.ReadLine()));

            Console.WriteLine("Dados do produto: " + P + ", Total: R$ " + P.valorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture));

            Console.Write("Digite a quantidade de produtos que saíram do estoque: ");
            P.realizaSaida(int.Parse(Console.ReadLine()));

            Console.WriteLine("Dados do produto: " + P + ", Total: R$ " + P.valorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadLine();
        }
    }
}
