using System;
using System.Globalization;

namespace S2E2
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionario;

            Console.Write("cpf: ");
            string cpf = Console.ReadLine();

            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Salário Bruto: ");
            double salarioBruto = double.TryParse(Console.ReadLine(), out var value) ? value : 0;

            Console.Write("Desconto: ");
            double Desconto = double.TryParse(Console.ReadLine(), out value) ? value : 0;

            funcionario = new Funcionario(nome, cpf, salarioBruto);

            Console.WriteLine(funcionario);

            Console.Write("Deseja aumentar o salário em qual percentagem? ");
            double aumento = double.TryParse(Console.ReadLine(), out value) ? value : 0;
            funcionario.AumentarSalario(aumento);

            Console.WriteLine(funcionario);


        }
    }
}
