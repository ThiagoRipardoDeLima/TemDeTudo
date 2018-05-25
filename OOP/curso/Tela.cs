using System;
using curso.dominio;

namespace curso
{
    class Tela
    {
        public static void mostrarMenu()
        {
            Console.WriteLine("1 – Listar produtos ordenadamente");
            Console.WriteLine("2 – Cadastrar produto");
            Console.WriteLine("3 – Cadastrar pedido");
            Console.WriteLine("4 – Mostrar dados de um pedido");
            Console.WriteLine("5 – Sair");
            Console.Write("Digite a opção desejada: ");
        }

        public static void mostrarProduto()
        {
            Console.WriteLine("LISTAGEM DE PRODUTOS:");
            for (int i = 0; i < Program.produtos.Count; i++)
                Console.WriteLine(Program.produtos[i]);
        }

        public static void cadastrarProduto()
        {
            Console.WriteLine("Digite os dados do produto:");
            Console.Write("Código: ");
            int codigo = int.Parse(Console.ReadLine());

            Console.Write("Descrição: ");
            string descricao = Console.ReadLine();

            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine());

            Program.produtos.Add(new Produto(codigo, descricao, preco));
            Program.produtos.Sort();
        }

        public static void cadastrarPedido()
        {
            Console.WriteLine("Digite os dados do pedido:");
            Console.Write("Código: ");
            int codigo = int.Parse(Console.ReadLine());

            Console.Write("Dia: ");
            int dia = int.Parse(Console.ReadLine());

            Console.Write("Mês: ");
            int mes = int.Parse(Console.ReadLine());

            Console.Write("Ano: ");
            int ano = int.Parse(Console.ReadLine());

            //PEDIDO CRIADO - LISTA DE ITENS DO PEDIDO VAZIA.
            Pedido pedido = new Pedido(codigo, dia, mes, ano);

            Console.Write("Quantos itens tem o pedido? ");
            int itens = int.Parse(Console.ReadLine());

            for(int i = 1; i <= itens; i++)
            {
                Console.WriteLine("Digite os dados do " + i + "º item:");
                Console.Write("Produto (código): ");
                int codProduto = int.Parse(Console.ReadLine());
                int pos = Program.produtos.FindIndex(x => x.codigo == codProduto);

                if (pos == -1)
                    throw new ModelException("Código do produto não encontrado: " + codProduto);
                
                Console.Write("Quantidade: ");
                int qteProduto = int.Parse(Console.ReadLine());

                Console.Write("Porcentagem de desconto: ");
                int descontoProduto = int.Parse(Console.ReadLine());
                //CRIA UM ITEM DE PEDIDO
                ItemPedido itemPedido = new ItemPedido(qteProduto, descontoProduto, Program.produtos[pos], pedido);
                //ADD A LISTA DE ITENS DO PEDIDO
                pedido.itens.Add(itemPedido);
            }
            //ADD A LISTA DE PEDIDO EFETUADAS
            Program.pedido.Add(pedido);
        }

        public static void mostrarPedido()
        {
            Console.Write("Digite o código do pedido: ");
            int codPedido = int.Parse(Console.ReadLine());
            int pos = Program.pedido.FindIndex(x => x.codigo == codPedido);
            if (pos == -1)
                throw new ModelException("Pedido não encontrado: " + codPedido);

            Console.WriteLine(Program.pedido[pos]);
        }

    }
}
