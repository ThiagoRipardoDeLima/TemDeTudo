using System;

namespace S3A3
{
    class Program
    {
        static void Main(string[] args)
        {

            int[,] mat;

            int N, cont;

            N = int.Parse(Console.ReadLine());

            mat = new int[N, N];

            for(int x = 0; x < N; x++)
            {
                string[] linha = Console.ReadLine().Split(" ");

                for(int j = 0; j < N; j++)
                {
                    mat[x,j] = int.Parse(linha[j]);
                }
            }

            Console.WriteLine("DIAGONAL PRINCIPAL:");
            for(int i = 0; i < N; i++)
            {
                Console.Write(mat[i, i] + " ");
            }
            Console.WriteLine();

            Console.Write("QUATIDADE DE NEGATIVOS = ");
            cont = 0;
            for (int x = 0; x < N; x++)
            {
                for (int j = 0; j < N; j++)
                {
                    if(mat[x,j] < 0)
                    {
                        cont++;
                    }
                }
            }
            Console.WriteLine(cont);



            Console.ReadLine();

        }
    }
}
