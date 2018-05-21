using System;

namespace S2E3
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();

            Console.WriteLine("Informe os dados do aluno:");
            Console.Write("Nome: ");
            aluno.Nome = Console.ReadLine();

            Console.Write("Nota 1 Semestre:");
            aluno.Nota.N1 = double.TryParse(Console.ReadLine(), out var value) ? value : 0;

            Console.Write("Nota 2 Semestre:");
            aluno.Nota.N2 = double.TryParse(Console.ReadLine(), out value) ? value : 0;

            Console.Write("Nota 3 Semestre:");
            aluno.Nota.N3 = double.TryParse(Console.ReadLine(), out value) ? value : 0;

            Console.WriteLine(aluno);

            Console.ReadLine();
            
        }
    }
}
