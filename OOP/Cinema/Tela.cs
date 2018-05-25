using System;
using System.Collections.Generic;
using Cinema.model;

namespace Cinema
{
    class Tela
    {
        public static void mostraMenu()
        {
            Console.WriteLine("--------------MENU-------------");
            Console.WriteLine("1 – Listar artistas ordenadamente");
            Console.WriteLine("2 - Listar filmes cadastrados");
            Console.WriteLine("3 – Cadastrar artista");
            Console.WriteLine("4 – Cadastrar filme");
            Console.WriteLine("5 – Mostrar dados de um filme");
            Console.WriteLine("6 – Sair");
            Console.Write("Digite a opção desejada: ");
        }

        public static void mostraArtistas()
        {
            Console.WriteLine("LISTAGEM DE ARTISTAS:");
            foreach (Artista ator in Program.artistas)
                Console.WriteLine(ator);
        }

        public static void mostrarFilmes()
        {
            Console.WriteLine("LISTAGEM DE FILMES:");
            if (Program.filmes.Count == 0)
                throw new ModelException("Nenhum filme encontrado!");

            foreach (Filme filme in Program.filmes)
                Console.WriteLine(filme);
        }

        public static void cadastrarArtista()
        {
            Console.WriteLine("Digite os dados do artista:");
            Console.Write("Código: ");
            int codigo = int.Parse(Console.ReadLine());
            int pos = Program.artistas.FindIndex(x => x.codigo == codigo);
            if (pos != -1)
                throw new ModelException("Código (" + codigo + ") ja cadastrado");

            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Valor do cachê: ");
            double cache = double.Parse(Console.ReadLine());

            Program.artistas.Add(new Artista(codigo, nome, cache));
            Program.artistas.Sort();
        }

        public static void cadastrarFilme()
        {
            Console.WriteLine("Digite os dados do filme:");
            Console.Write("Código: ");
            int codigo = int.Parse(Console.ReadLine());
            int pos = Program.filmes.FindIndex(x => x.codigo == codigo);
            if (pos != -1)
                throw new ModelException("Código (" + codigo + ") ja cadastrado");

            Console.Write("Título: ");
            string titulo = Console.ReadLine();

            Console.Write("Ano: ");
            int ano = int.Parse(Console.ReadLine());

            //Cria Filme - sem participante
            Filme filme = new Filme(codigo, titulo, ano);

            Console.Write("Quantas participações tem o filme? ");
            int part = int.Parse(Console.ReadLine());

            for(int i = 1; i <= part; i++)
            {
                Console.WriteLine("Digite os dados do " + i + "º participante");
                Console.Write("Artista (código): ");
                int codArtista = int.Parse(Console.ReadLine());
                int posArtista = Program.artistas.FindIndex(x => x.codigo == codArtista);
                if (posArtista == -1)
                    throw new ModelException("Artista não encontrado!");

                Console.Write("Desconto: ");
                double desconto = double.Parse(Console.ReadLine());
                //cria participantes do filme
                Participacao ator = new Participacao(desconto, Program.artistas[posArtista], filme);

                //adiciona participante ao filme
                filme.adicionaParticipante(ator);
            }
            //Adiciona filme criado a lista de filmes
            Program.filmes.Add(filme);
        }

        public static void mostrarDetalhesFilme()
        {
            Console.Write("Digite o código do filme: ");
            int codigo = int.Parse(Console.ReadLine());
            int pos = Program.filmes.FindIndex(x => x.codigo == codigo);
            if (pos == -1)
                throw new ModelException("Filme não encontrado!");

            Console.WriteLine(Program.filmes[pos]);
        }
    }
}
