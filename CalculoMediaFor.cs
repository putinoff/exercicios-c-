using System;

class Program
{
    static void Main()
    {
        double somaNotas = 0;
        int totalAlunos = 30;

        for (int i = 1; i <= totalAlunos; i++)
        {
            Console.WriteLine($"Digite a nota do aluno {i}:");
            double nota = Convert.ToDouble(Console.ReadLine());
            somaNotas += nota;
        }

        double media = somaNotas / totalAlunos;
        Console.WriteLine($"A média geral da turma é: {media:F2}");
    }
}
