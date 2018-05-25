using System;

namespace S3E3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz;
            int M,N,numeroDaMatriz;
            string[] linha;

            //busca o tamanho da matriz
            linha = Console.ReadLine().Split(' ');
            M = int.Parse(linha[0]);
            N = int.Parse(linha[1]);

            //inicializa matriz
            matriz = new int[M, N];

            //preenche matriz
            linha.Initialize();
            for (int x = 0; x < M; x++)
            {
                linha = Console.ReadLine().Split(" ");
                for(int j = 0; j < N; j++)
                {
                    matriz[x, j] = int.Parse(linha[j]);
                }
            }

            //ler um numero da matriz
            numeroDaMatriz = int.Parse(Console.ReadLine());

            for (int x = 0; x < M; x++)
            {
                for (int j = 0; j < N; j++)
                {
                    if(matriz[x, j] == numeroDaMatriz)
                    {
                        //acima
                        if (x - 1 >= 0)
                        {
                            Console.WriteLine("Acima: " + matriz[x - 1, j]);
                        }
                        //abaixo
                        if(x + 1 < M)
                        {
                            Console.WriteLine("Abaixo: " + matriz[x + 1, j]);
                        }
                        //esquerda
                        if(j - 1 >= 0)
                        {
                            Console.WriteLine("Esquerda: " + matriz[x, j - 1]);
                        }
                        //direita
                        if(j + 1 < N)
                        {
                            Console.WriteLine("Direita: " + matriz[x, j + 1]);
                        }

                        //paleativo para interromper o laço for
                        j = N;
                        x = M;

                    }
                    Console.Write(matriz[x, j] + " ");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
