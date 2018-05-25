using System;
using System.Collections.Generic;

namespace S3A4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> lista = new List<string>();

            lista.Add("Joao");
            lista.Add("Maria");
            lista.Add("Ana");
            lista.Add("Jose");

            int pos = lista.FindIndex(x => x == "Maria");
            Console.WriteLine("Posição da Maria = " + pos);

            for(int x = 0; x < lista.Count; x++)
            {
                Console.WriteLine(lista[x]);
            }

        }
    }
}
