using System;
using System.Collections.Generic;

namespace S3A5
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> A = new HashSet<int>();
            HashSet<int> B = new HashSet<int>();
            
            PopulaConjunto(A, "A");
            PopulaConjunto(B, "B");

            ImprimeConjunto(A, "A");
            ImprimeConjunto(B, "B");
            Console.WriteLine();
            //Diferenca de conjuntos - retira de A os elementos em comum com o B.
            A.ExceptWith(B);

            Console.WriteLine("Diferença do conjunto A em relação ao B: ");

            ImprimeConjunto(A, "A");
            ImprimeConjunto(B, "B");
            Console.WriteLine();

            PopulaConjunto(A, "A");
            PopulaConjunto(B, "B");

            //Intersecção do Conjunto A em relação ao B - retira de A os elementos que não são comuns aos dois conjuntos.
            A.IntersectWith(B);

            Console.WriteLine("Interseção do conjunto A em relação ao B: ");

            ImprimeConjunto(A, "A");
            ImprimeConjunto(B, "B");
            Console.WriteLine();

            PopulaConjunto(A, "A");
            PopulaConjunto(B, "B");

            //União do Conjunto A em relação ao B - Adiciona em A os elementos de B, excetos os que já estão em A.
            A.UnionWith(B);

            Console.WriteLine("União do conjunto A em relação ao B: ");

            ImprimeConjunto(A, "A");
            ImprimeConjunto(B, "B");
            Console.WriteLine();

            PopulaConjunto(A, "A");
            PopulaConjunto(B, "B");

            Console.WriteLine();

            Console.Write("Digite um valor inteiro: ");
            int N = int.Parse(Console.ReadLine());

            string mensagem = N + " não pertence ao conjunto B";
            if(B.Contains(N))
                mensagem = N + " pertence ao conjunto B";

            Console.WriteLine(mensagem);


            Console.ReadLine();
        }

        static void ImprimeConjunto(HashSet<int> conjunto, string nomeConjunto)
        {
            Console.WriteLine("Conjunto " + nomeConjunto + ":");
            foreach (int i in conjunto)
                Console.WriteLine(i);
        }

        static void PopulaConjunto(HashSet<int> conjunto, string nomeConjunto)
        {
            if(nomeConjunto == "A")
            {
                conjunto.Add(3);
                conjunto.Add(5);
                conjunto.Add(8);
                conjunto.Add(9);
            }
            else
            {
                conjunto.Add(3);
                conjunto.Add(4);
                conjunto.Add(5);
            }
        }
    }
}
