using System;
using System.Globalization;

namespace S2E2
{
    class Funcionario
    {
        private string nome;
        private double salarioBruto;
        private double desconto;

        public string Nome { get => nome; set => nome = value; }
        public double SalarioBruto { get => salarioBruto; set => salarioBruto = value; }
        public double Desconto { get => desconto; set => desconto = value; }

        public double SalarioLiquido() => SalarioBruto - Desconto;

        public void AumentarSalario(double porcentagem) => SalarioBruto += SalarioBruto * (porcentagem / 100);

        public override string ToString()
        {
            return "Dados do Funcionario: "
                + Nome
                + ", R$ "
                + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
