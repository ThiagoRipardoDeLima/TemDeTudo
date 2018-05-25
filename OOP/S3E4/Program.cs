using System;
using System.Collections.Generic;
using S2E2;

namespace S3E4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Funcionario> funcionarios = new List<Funcionario>();
            Funcionario funcionario;
            int numeroDeFuncionarios;
            string cpf, nome;
            double salario, percentualAumento;

            Console.Write("Quantos funcionários serão cadastrados? ");
            numeroDeFuncionarios = int.Parse(Console.ReadLine());

            for(int i = 1; i <= numeroDeFuncionarios; i++)
            {
                Console.WriteLine("Dados do " + i + "º funcionário:");
                Console.Write("CPF: ");
                cpf = Console.ReadLine();

                if (funcionarios.FindIndex(x=>x.cpf == cpf) != -1)
                {
                    do
                    {
                        Console.WriteLine();
                        Console.WriteLine("Funcionário ja cadastrado. Informe outro");
                        Console.WriteLine("Dados do " + i + "º funcionário:");
                        Console.Write("CPF: ");
                        cpf = Console.ReadLine();
                    } while (funcionarios.FindIndex(x => x.cpf == cpf) != -1);
                }

                Console.Write("Nome: ");
                nome = Console.ReadLine();

                Console.Write("Salário: ");
                salario = double.TryParse(Console.ReadLine(), out var sal) ? sal : 0;
                funcionario = new Funcionario(nome, cpf, salario);
                funcionarios.Add(funcionario);
                Console.WriteLine();
            }
            
            cpf = "";
            Console.Write("Digite o cpf do funcionário que terá aumento: ");
            cpf = Console.ReadLine();

            int pos = funcionarios.FindIndex(x => x.cpf == cpf);
            if(pos == -1)
            {
                Console.WriteLine("CPF Inexistente. Nenhum aumento será concedido.");
            }
            else
            {
                Console.Write("Digite a porcentagem de aumento: ");
                percentualAumento = double.Parse(Console.ReadLine());
                funcionarios[pos].AumentarSalario(percentualAumento);
            }

            Console.WriteLine();
            Console.WriteLine("Listagem atualizada de funcionários:");
            for(int i = 0; i < funcionarios.Count; i++)
            {
                Console.WriteLine(funcionarios[i]);
            }

            Console.ReadLine();
        }
    }
}   