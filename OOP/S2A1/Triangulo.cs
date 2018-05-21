using System;
using System.Collections.Generic;
using System.Text;

namespace S2A1
{
    class Triangulo
    {
        public double a, b, c;

        public double area()
        {
            double Area,p;

            p = (a + b + c) / 2.0;

            Area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

            return Area;
        }
    }
}
