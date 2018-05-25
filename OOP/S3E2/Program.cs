using System;

namespace S3E2
{
    class Program
    {
        static void Main(string[] args)
        {
            Quarto[] quarto = new Quarto[10];
            var value = 0;

            Console.Write("Quantos aluguéis serão registrados: ");
            int N = int.TryParse(Console.ReadLine(), out value) ? value : 0;
            
            if (N == 0)
            {
                Console.WriteLine("Quartos ocupados: \n Nenhum quarto ocupado. Programa será encerrado!");
                Environment.Exit(0);
            }

            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine("Dados do " + (i) + "º aluguel:");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();

                Console.Write("Email: ");
                string email = Console.ReadLine();

                Console.Write("Quarto: ");
                int pos = int.TryParse(Console.ReadLine(), out value) ? value : 0;
                quarto[pos] = new Quarto(nome, email);
            }

            MostraQuartosOcupado(quarto);

            Console.ReadLine();
            
        }

        static void MostraQuartosOcupado(Quarto[] quarto)
        {
            Console.WriteLine("Quartos ocupado: ");
            for(int x = 0; x < 10; x++)
            {
                if(quarto[x] != null)
                {
                    Console.WriteLine(x + ": " + quarto[x]);
                }
                
            }
        }
    }
}
