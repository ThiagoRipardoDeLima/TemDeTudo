using System;

namespace S3A6
{
    class Retangulo : Figura
    {
        public double largura { get; set; }
        public double altura { get; set; }

        public Retangulo(double largura, double altura, string cor) : base(cor)
        {
            this.largura = largura;
            this.altura = altura;
        }

        public override double area()
        {
            return largura * altura;
        }

        public override double perimetro()
        {
            return (largura + altura) * 2;
        }


    }
}
