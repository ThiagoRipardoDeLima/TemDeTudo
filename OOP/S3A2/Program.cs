using System;
using System.Globalization;
using S3A1;

namespace S3A2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Produto[] vet;
            double soma, media;
            int N;

            Console.Write("Informe a quantidade de Produtos a serem cadastrados: ");
            N = int.TryParse(Console.ReadLine(), out var lista) ? lista : 0;

            vet = new Produto[N];

            if (vet.Length <= 0)
            {
                Console.WriteLine("Nenhum Produto sera cadastrado. Programa será encerrado!");

                Console.ReadLine();

                Environment.Exit(0);
            }

            for (int i = 0; i < N; i++)
            {
                Console.Write("Nome do Produto: ");
                string nome = Console.ReadLine();

                Console.Write("Digite o Preco do Produto: ");
                double preco = double.TryParse(Console.ReadLine(), out var precoProduto) ? precoProduto : 0;

                vet[i] = new Produto(nome, preco);
            }

            soma = 0;
            foreach (Produto produto in vet)
            {
                soma += produto.preco;
            }

            media = soma / N;

            Console.WriteLine("PREÇO MEDIO = R$ " + media.ToString("F2",CultureInfo.InvariantCulture));

            Console.ReadLine();
        }
    }
}
