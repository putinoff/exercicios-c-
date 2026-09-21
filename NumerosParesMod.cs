using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Números pares entre 2 e 100:");

        for (int i = 2; i <= 100; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}
