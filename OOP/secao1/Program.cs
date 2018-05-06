using System;
using System.Globalization;

namespace OOp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // teste();
            // Console.WriteLine("Terminou teste..Iniciando conversao");
            // conversao();
            // calculaBaskara();
            // mediaSimples();
            // mediaEmPares();

            new Exercicio1().exercicio1();

        }

        static void teste(){
            Console.WriteLine("Hello World!");
            Console.WriteLine("Ola Mundo 2!!!");
            
            double x = 10.357840;

            Console.WriteLine(x.ToString("F2"));
            Console.WriteLine(x.ToString("F4"));
            Console.WriteLine(x.ToString("F2"), CultureInfo.InvariantCulture);
        }

        static void conversao()
        {
            string x;
            int y;
            double z;
            char w; 

            x = Console.ReadLine();
            y = int.Parse(Console.ReadLine());
            z = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            w = char.Parse(Console.ReadLine());

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine(w);

            Console.ReadLine();

        }

        static void calculaBaskara()
        {
            double a, b, c, delta, x1, x2;

            Console.WriteLine("Informe os valores de a, b e c: ");
            string[] vet = Console.ReadLine().Split(' ');

            a = double.Parse(vet[0], CultureInfo.InvariantCulture);
            b = double.Parse(vet[1], CultureInfo.InvariantCulture);
            c = double.Parse(vet[2], CultureInfo.InvariantCulture);

            //calcula delta (b^2 - 4*a*c)
            delta =  b * b - 4 * a * c;

            //calcula Baskara (-b+-(raiz de delta)/2*a)
            
            //se nao der para calcular exibe mensagem
            if ( a == 0.0 || delta < 0)
            {
                Console.WriteLine("IMPOSSIVEL CALCULAR");
            }
            else
            {
                x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                x2 = (-b - Math.Sqrt(delta)) / (2 * a);

                Console.WriteLine("X1 = " + x1.ToString("F4"), CultureInfo.InvariantCulture);
                Console.WriteLine("X2 = " + x2.ToString("F4"), CultureInfo.InvariantCulture);
            }
            Console.ReadLine();
        }

        static void mediaSimples()
        {
            int idade, soma, cont;
            double media;

            soma = 0;
            cont = 0;
            Console.WriteLine("Informe a idade para calculo da media:");
            idade = int.Parse(Console.ReadLine());

            while(idade >= 0)
            {
                soma += idade;
                cont++;
                idade = int.Parse(Console.ReadLine());
            }

            if (cont == 0)
            {
                Console.WriteLine("IMPOSSÍVEL CALCULAR");
            }
            else
            {
                media = (double)soma/cont;
                Console.WriteLine("Media: " + media.ToString("F2", CultureInfo.InvariantCulture));
            }


        }

        static void mediaEmPares()
        {
            int pares;
            double v1, v2, media;

            Console.WriteLine("Diga Quantos pares de valores voce ira inserir?");
            pares = int.Parse(Console.ReadLine());
            
            if (pares >= 1)
            {
                for (int x = 0 ; x < pares ; x++)
                {
                    Console.WriteLine("Informe o " + x + "º Par de Valores");
                    
                    string[] vet = Console.ReadLine().Split(' ');
                    
                    v1 = double.Parse(vet[0], CultureInfo.InvariantCulture);
                    v2 = double.Parse(vet[1], CultureInfo.InvariantCulture);

                    if (v2 == 0)
                    {
                        Console.WriteLine("Não existe");
                        break;
                    }

                    media = v1 / v2;

                    Console.WriteLine("Entrada: " + v1 + " " + v2 + " Saida: " + media.ToString("F3", CultureInfo.InvariantCulture));
                }
            }
            else
            {
                Console.WriteLine("Quantidade de pares insuficientes para cálculo da média.");
            }





        }

    }
}
