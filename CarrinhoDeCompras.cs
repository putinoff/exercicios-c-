using System;

class Program
{
    static void Main()
    {
        string[] itens = new string[3];

        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine($"Digite o item numero {i + 1}:");
            itens[i] = Console.ReadLine();
        }

        Console.WriteLine("\n--- SEU CARRINHO ---");
        foreach (string item in itens)
        {
            Console.WriteLine($"- {item}");
        }
    }
}
