using System;
using System.Collections.Generic;

namespace S3A6
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Figura> lista = new List<Figura>();

            Console.Write("Quantas figuras vôce irá digitar? ");
            int N = int.Parse(Console.ReadLine());

            for(int i = 1; i <= N; i++)
            {
                Console.Write("Figura " + i + " - triângulo ou retângulo (t/r)? ");
                char ch = char.Parse(Console.ReadLine().ToLower());

                if(ch == 'r')
                {
                    Console.Write("Largura: ");
                    double largura = double.Parse(Console.ReadLine());
                    Console.Write("Altura: ");
                    double altura = double.Parse(Console.ReadLine());

                    Figura f = new Retangulo(largura, altura, "Verde");
                    lista.Add(f);
                }
                else
                {
                    Console.Write("Lado a: ");
                    double a = double.Parse(Console.ReadLine());
                    Console.Write("lado b: ");
                    double b = double.Parse(Console.ReadLine());
                    Console.Write("lado c: ");
                    double c = double.Parse(Console.ReadLine());

                    Figura f = new Triangulo(a, b, c, "Azul");
                    lista.Add(f);
                }
            }

            Console.WriteLine("Área das figuras:");
            foreach (Figura fi in lista)
            {
                int pos = lista.FindIndex(x => x == fi) + 1;
                Console.WriteLine("Figura " + pos + "(" + fi.cor + "): " + fi.area());
            }

            Console.WriteLine();

            Console.WriteLine("Perímetro das figuras:");
            foreach (Figura fi in lista)
            {
                int pos = lista.FindIndex(x => x == fi) + 1;
                Console.WriteLine("Figura " + pos + "(" + fi.cor + "): " + fi.perimetro());
            }



        }
    }
}
