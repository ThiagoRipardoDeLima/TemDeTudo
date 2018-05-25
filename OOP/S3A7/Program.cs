using System;
using System.Globalization;

namespace S3A7
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Numero da conta: ");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("Nome do titular: ");
            string titular = Console.ReadLine();

            Console.Write("Limite de saque: ");
            double limiteDeSaque = double.Parse(Console.ReadLine());

            Conta conta = new Conta(numero, titular, limiteDeSaque);

            Console.WriteLine();

            Console.Write("Informe um valor para depósito: ");
            double valorDeposito = double.Parse(Console.ReadLine());
            conta.depositar(valorDeposito);
            Console.WriteLine("Novo saldo = R$ " + conta.saldo);

            Console.WriteLine();

            Console.WriteLine("Informe um valor para saque: ");
            double valorSaque = double.Parse(Console.ReadLine());

            try
            {
                conta.sacar(valorSaque);
                Console.WriteLine("Novo saldo = R$ " + conta.saldo.ToString("F2", CultureInfo.InvariantCulture);
            }
            catch(OperacaoException e)
            {
                Console.WriteLine(e.Message);
            }


            Console.ReadLine();
        }
    }
}
    