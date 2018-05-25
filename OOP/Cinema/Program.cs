using System;
using System.Collections.Generic;
using Cinema.model;

namespace Cinema
{
    class Program
    {
        public static List<Artista> artistas = new List<Artista>();
        public static List<Filme> filmes = new List<Filme>();
        static void Main(string[] args)
        {
            int opcao = 0;

            cargaInicalAplicacao();
            artistas.Sort();

            while(opcao != 5)
            {

                Console.Clear();
                Tela.mostraMenu();
                
                try
                {
                    opcao = int.Parse(Console.ReadLine());
                }
                catch(Exception e)
                {
                    Console.WriteLine("Opção (" + opcao +") invalida!");
                    //opcao = 0;
                }

                Console.WriteLine();

                if(opcao == 1)
                {
                    Tela.mostraArtistas();
                }
                else if(opcao == 2)
                {
                    try
                    {

                        Tela.mostrarFilmes();

                    }
                    catch(ModelException e)
                    {

                        Console.WriteLine(e.Message);

                    }
                    catch(Exception e)
                    {

                        Console.WriteLine("Erro inesperado: " + e.Message);

                    }
                }
                else if(opcao == 3)
                {
                    try
                    {

                        Tela.cadastrarArtista();
                        
                    }
                    catch(ModelException e)
                    {
                        Console.WriteLine(e.Message);
                    }
                    catch(Exception e)
                    {
                        Console.WriteLine("Erro inesperado: " + e.Message);
                    }
                }
                else if(opcao == 4)
                {
                    try
                    {

                        Tela.cadastrarFilme();
                        
                    }
                    catch(Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
                else if(opcao == 5)
                {

                    Tela.mostrarDetalhesFilme();
                    
                }
                else if (opcao == 6)
                {

                    Console.WriteLine("Programa encerrado!");
                    
                }
                else
                {
                    Console.WriteLine("Opção invalida!");
                }

                Console.ReadLine();

            }
        }

        static void cargaInicalAplicacao()
        {
            artistas.Add(new Artista(101, "Scarlett Johansson", 4000000.00));
            artistas.Add(new Artista(102, "Chris Evans", 2500000.00));
            artistas.Add(new Artista(103, "Robert Downey Jr.", 3000000.00));
            artistas.Add(new Artista(104, "Morgan Freeman", 4000000.00));
        }
    }
}
