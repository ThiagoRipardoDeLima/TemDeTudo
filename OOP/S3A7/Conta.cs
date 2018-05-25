using System;

namespace S3A7
{
    class Conta
    {
        public int numero { get; set; }
        public string titular { get; set; }
        public double saldo { get; set; }
        public double limiteDeSaque { get; set; }
        
        public Conta(int numero, string titular, double limiteDeSaque)
        {
            this.numero = numero;
            this.titular = titular;
            this.limiteDeSaque = limiteDeSaque;
            this.saldo = 0.00;
        }

        public void depositar(double valor)
        {
            this.saldo += valor;
        }

        public void sacar(double valor)
        {
            if (saldo < valor)
                throw new OperacaoException("Não há saldo suficiente! Saque cancelado.");

            if (limiteDeSaque < valor)
                throw new OperacaoException("Valor do saque é superior ao limite da conta! Saque cancelado.");

            saldo -= valor;
        }

    }
}
