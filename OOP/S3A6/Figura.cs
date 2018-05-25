
namespace S3A6
{
    /// <summary>
    /// Classe genérica para representação de figuras
    /// </summary>
    abstract class Figura
    {

        public string cor { get; set; }

        public Figura(string cor)
        {
            this.cor = cor;
        }

        public abstract double area();

        public abstract double perimetro();
    }
}
