using System;
using System.Globalization;

namespace S2A1
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo X, Y;
            //double aX, bX, cX, aY, bY, cY;
            double areaX, areaY, p;

            X = new Triangulo();
            Y = new Triangulo();

            X.a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            X.b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            X.c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Y.a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Y.b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Y.c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            areaX = X.area();

            areaY = Y.area();

            Console.WriteLine("Area do Triângulo X: " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Area do Triângulo Y: " + areaY.ToString("F4", CultureInfo.InvariantCulture));

            if (areaX > areaY)
            {
                Console.WriteLine("Triângulo de Área maior: X");
            }
            else if (areaX < areaY)
            {
                Console.WriteLine("Triângulo de Área Maior: Y");
            }
            else
            {
                Console.WriteLine("ÁREAS IGUAIS");
            }
            Console.ReadLine();
        }
    }
}
