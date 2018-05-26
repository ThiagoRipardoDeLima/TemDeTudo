using System;
using System.Collections.Generic;
using System.Text;

namespace RevendaDeCarro
{
    /// <summary>
    /// Classe que interage com o usuário
    /// </summary>
    class Tela
    {
        public static void mostraMenu()
        {
            Console.WriteLine("-----------------MENU----------------");
            Console.WriteLine("1 – Listar marcas");
            Console.WriteLine("2 – Listar carros de uma marca ordenadamente");
            Console.WriteLine("3 – Cadastrar marca");
            Console.WriteLine("4 – Cadastrar carro");
            Console.WriteLine("5 – Cadastrar acessório");
            Console.WriteLine("6 – Mostrar detalhes de um carro");
            Console.WriteLine("7 – Sair");
            Console.Write("Digite a opção desejada: ");
        }

        public static void listaMarcas() { }

        public static void listaCarros() { }

        public static void cadastrarMarca() { }

        public static void cadastrarCarro() { }

        public static void cadastrarAcessorio() { }

        public static void mostraDetalheCarro() { }
        
        public static void encerrarPrograma() { }

    }
}
