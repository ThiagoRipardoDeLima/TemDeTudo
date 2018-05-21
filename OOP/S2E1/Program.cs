using System;
using System.Globalization;

namespace S2E1
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo X;
            string[] entrada;


            Console.Write("Informe os valores de Altura e Largura do Retângulo, respectivamente: ");
            entrada = Console.ReadLine().Split(" ");

            X = new Retangulo   
            {
                Altura = double.TryParse(entrada[0], out var value) ? value : 0,
                Largura = double.TryParse(entrada[1], out value) ? value : 0
            };

            Console.WriteLine(X);

            Console.ReadLine();

        }
    }
}
