using System;

class Program
{
    static void Main()
    {
        int idade;
        do
        {
            Console.WriteLine("Quantos anos você tem?");
            idade = Convert.ToInt32(Console.ReadLine());
            if (idade < 1 || idade > 120)
            {
                Console.WriteLine("Idade inválida, tente novamente:");
            }
        }
        while (idade < 1 || idade > 120);

        Console.WriteLine($"Cadastro concluído!, a idade do cliente é de {idade} anos");
    }
}
