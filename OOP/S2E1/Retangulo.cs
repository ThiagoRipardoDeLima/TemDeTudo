using System;
using System.Globalization;

namespace S2E1
{
    class Retangulo
    {
        private double largura;
        private double altura;

        public double Largura { get => largura; set => largura = value; }
        public double Altura { get => altura; set => altura = value; }

        public double Area()
        {
            return Largura * Altura;
        }

        public double Perimetro()
        {
            return 2 * (Largura + Altura);
        }

        public double Diagonal()
        {
            return Math.Sqrt(Math.Exp(Largura) + Math.Exp(Altura));
        }

        public override string ToString()
        {
            return "AREA: " + Area().ToString("F2", CultureInfo.InvariantCulture)
                + "\n"+"PERIMETRO: " + Perimetro().ToString("F2", CultureInfo.InvariantCulture)
                + "\n"+"DIAGONAL: " + Diagonal().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
