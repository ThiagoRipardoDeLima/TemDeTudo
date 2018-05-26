using RevendaDeCarro.model;
using System;
using System.Collections.Generic;

namespace RevendaDeCarro
{
    class Program
    {
        public static List<Marca> marcas = new List<Marca>();
        public static List<Carro> carros = new List<Carro>();
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        static void cargaInicialDaAplicacao()
        {
            /*
             * INICIALIZA COM 2 MARCAS E 3 CARROS PARA CADA MARCA 
             */

            Marca Volkswagem = new Marca(1001, "Volkswagem", "Alemanha");
            Marca GM = new Marca(1002, "General Motors", "Estados Unidos");
            marcas.Add(Volkswagem);
            marcas.Add(GM);
            //Volks
            carros.Add(new Carro(101, "Fusca", 1980, 5000.00, Volkswagem));
            carros.Add(new Carro(102, "Golf", 2016, 60000.00, Volkswagem));
            carros.Add(new Carro(103, "Fox", 2017, 30000.00, Volkswagem));
            //GM
            carros.Add(new Carro(104, "Cruze", 2016, 30000.00, GM));
            carros.Add(new Carro(105, "Cobalt", 2015, 25000.00, GM));
            carros.Add(new Carro(106, "Cobalt", 2017, 35000.00, GM));

        }
    }
}
