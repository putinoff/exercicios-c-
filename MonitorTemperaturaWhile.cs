using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite a temperatura inicial da máquina:");
        double temp = Convert.ToDouble(Console.ReadLine());

        while (temp < 80.0)
        {
            Console.WriteLine($"Temperatura atual: {temp}°C (Normal). Lendo nova temperatura:");
            temp = Convert.ToDouble(Console.ReadLine());
        }

        Console.WriteLine($"ALERTA: Superaquecimento detectado! Temperatura: {temp}°C");
    }
}
