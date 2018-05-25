using System;
using System.Collections.Generic;
using System.Globalization;

namespace curso.dominio
{
    class Pedido
    {
        public int codigo { get; set; }
        public DateTime data { get; set; }
        public List<ItemPedido> itens { get; set; }

        public Pedido(int codigo, int dia, int mes, int ano)
        {
            this.codigo = codigo;
            data = new DateTime(ano,mes,dia);
            itens = new List<ItemPedido>();
        }

        public double valorTotal()
        {
            double valorTotal = 0.00;
            for(int x = 0; x < itens.Count; x++)
                valorTotal += itens[x].subTotal();

            return valorTotal;
        }

        public string dataFormatada()
        {
            return data.Day + "/" + data.Month + "/" + data.Year;
        }

        public string imprimeItens()
        {
            string lista = "";
            for (int i = 0; i < itens.Count; i++)
                lista += itens[i] + "\n";

            return lista;
        }

        public override string ToString()
        {
            return "Pedido " + codigo + ", data: " + dataFormatada() + "\n"
                + "Itens: \n"
                + imprimeItens()
                + "Total do pedido: "
                + valorTotal().ToString("F2");
        }

    }
}
