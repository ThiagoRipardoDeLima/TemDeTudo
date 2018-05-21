using System;
using System.Globalization;

namespace S2A2
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto P;

            P = new Produto();

            Console.WriteLine("Digite os dados do Produto:");
            Console.Write("Nome: ");
            P.nome = Console.ReadLine();

            Console.Write("Preço: ");
            P.preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantidade em estoque: ");
            P.quantidadeEmEstoque = int.Parse(Console.ReadLine());

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
