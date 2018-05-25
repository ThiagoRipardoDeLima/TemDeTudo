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
            HashSet<int> C = new HashSet<int>();
            HashSet<int> D = new HashSet<int>();

            PopulaConjunto(A, "A");
            PopulaConjunto(B, "B");
            PopulaConjunto(C, "C");

            ImprimeConjunto(A, "A");
            ImprimeConjunto(B, "B");
            ImprimeConjunto(C, "C");
            Console.WriteLine();

            D.UnionWith(A);
            D.UnionWith(B);
            D.UnionWith(C);
            
            Console.WriteLine("Total de alunos: " + D.Count);

            ImprimeConjunto(D, "D");

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
            Console.Write("Quantos Alunos possui o curso " + nomeConjunto + "? ");
            int alunos = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite os códigos dos alunos do curso " + nomeConjunto + ":");
            for(int aluno = 1; aluno <= alunos; aluno++)
            {
                int codigo = int.Parse(Console.ReadLine());
                conjunto.Add(codigo);
            }
        }
    }
}
