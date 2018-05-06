using System;

namespace OOp
{
    class Exercicio1
    {
        
        public void exercicio1()
        {
            Console.WriteLine(enunciado()); 
        }

        private string enunciado()
        {
            string enunciado = 
                "1) Um agricultor precisa aplicar veneno em suas plantações. Para isso ele precisa escolher um frasco e uma bomba para"
            +   "aplicação. O frasco de veneno possui um volume de veneno líquido medido em ml (mililitro). Já a bomba de aplicação"
            +   "possui uma vazão* medida em ml/s (mililitro por segundo). O agricultor deseja saber: dado o volume inicial de um frasco"
            +   "de veneno (em ml), a vazão da bomba (em ml/s), e um tempo (em s), qual volume de veneno restará no frasco após o uso"
            +   "da bomba durante este tempo?\n"
            +   "* Vazão, neste contexto, significa o quanto a bomba consegue bombear em um certo intervalo de tempo.\n\n"
            +   "Entrada:\n\n"
            +   "A entrada possui três números inteiros representando respectivamente: o volume inicial de um frasco de veneno (em ml),"
            +   "a vazão da bomba (em ml/s), e um tempo (em s).\n\n"
            +   "Saída:\n\n"
            +   "A saída contém um número inteiro representando o volume de veneno (em ml) restante no frasco depois o uso da bomba"
            +   "durante o tempo informado. Se o volume do frasco não for suficiente, mostre a mensagem 'nao eh possivel'.\n\n"
            +   "Exemplo: Entrada: 400 2 30 Saida: 340 - Entrada: 500 10 60 Saida: nao é possível.";
        
            return enunciado;
        }


        
        
        
    }
}