using System;
using System.Globalization;

namespace S2E2
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionario = new Funcionario();

            Console.Write("Nome: ");
            funcionario.Nome = Console.ReadLine();

            Console.Write("Salário Bruto: ");
            funcionario.SalarioBruto = double.TryParse(Console.ReadLine(), out var value) ? value : 0;

            Console.Write("Desconto: ");
            funcionario.Desconto = double.TryParse(Console.ReadLine(), out value) ? value : 0;

            Console.WriteLine(funcionario);

            Console.Write("Deseja aumentar o salário em qual percentagem? ");
            double aumento = double.TryParse(Console.ReadLine(), out value) ? value : 0;
            funcionario.AumentarSalario(aumento);

            Console.WriteLine(funcionario);


        }
    }
}
