using System;

namespace S3E1
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta;

            Console.Write("Digite o número da conta: ");
            int numeroConta = int.TryParse(Console.ReadLine(), out var value) ? value : 0000;

            Console.Write("Digite o nome do titular da conta: ");
            string titular = Console.ReadLine();

            Console.Write("Haverá depósito inicial(S/N)? ");
            char deposito = Char.Parse(Console.ReadLine().ToUpper());

            if (deposito == 'S')
            {
                Console.Write("Digite o valor do depósito inicial: ");
                double depositoInicial = double.TryParse(Console.ReadLine(), out var depIni) ? depIni : 0;

                conta = new ContaCorrente(numeroConta, titular, depositoInicial);
                Console.WriteLine(conta);
            }
            else
            {
                conta = new ContaCorrente(numeroConta, titular);
                Console.WriteLine(conta);
            }
            Console.WriteLine("");

            Console.Write("Digite um valor para depósito: ");
            double valorInformado = double.TryParse(Console.ReadLine(), out var result) ? result : 0;
            conta.Deposito(valorInformado);
            Console.WriteLine(conta);

            Console.WriteLine("");

            Console.Write("Digite um valor para saque: ");
            valorInformado = 0;
            valorInformado = double.TryParse(Console.ReadLine(), out result) ? result : 0;
            conta.Saque(valorInformado);
            Console.WriteLine(conta);

            Console.ReadLine();
        }
    }
}
