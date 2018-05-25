using System;
using System.Globalization;

namespace S3E1
{
    class ContaCorrente
    {
        int NumeroConta { get; set; }
        string Titular { get; set; }
        double Saldo { get; set; }

        const double TaxaSaque = 5.00;

        public ContaCorrente(int numeroConta, string titular)
        {
            this.NumeroConta = numeroConta;
            this.Titular     = titular;
            Console.WriteLine("Conta criada");
        }

        public ContaCorrente(int numeroConta, string titular, double saldo)
        {
            this.NumeroConta = numeroConta;
            this.Titular     = titular;
            this.Saldo       = saldo;
            Console.WriteLine("Conta criada");
        }

        public void Saque(double valorSaque)
        {
            Saldo -= valorSaque;
            Console.WriteLine("Conta Atualizada");
        }

        public void Deposito(double valorDeposito)
        {
            Saldo += valorDeposito;
            Console.WriteLine("Conta Atualizada");
        }

        public override string ToString()
        {
            return "Conta "
                + NumeroConta.ToString()
                + ", Titular:"
                + Titular
                + ", Saldo: R$ "
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
