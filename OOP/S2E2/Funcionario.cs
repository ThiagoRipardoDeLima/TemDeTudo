using System;
using System.Globalization;

namespace S2E2
{
    public class Funcionario
    {
        public string nome { get; set; }
        public string cpf { get; private set; }
        public double salarioBruto { get; private set; }
        public double desconto { get; private set; }

        public Funcionario(string nome, string cpf)
        {
            this.nome = nome;
            this.cpf = cpf;
            this.salarioBruto = 0;
        }

        public Funcionario(string nome, string cpf, double salarioBruto)
        {
            this.nome = nome;
            this.cpf = cpf;
            this.salarioBruto = salarioBruto;
        }

        public double SalarioLiquido() => salarioBruto - desconto;

        public void AumentarSalario(double porcentagem) => salarioBruto = salarioBruto + (salarioBruto * (porcentagem / 100));

        public override string ToString()
        {
            return 
                cpf
                + ", "
                + nome
                + ", Sal. Bruto R$"
                + salarioBruto.ToString("F2", CultureInfo.InvariantCulture)
                + ", Sal. Liquido R$ "
                + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
