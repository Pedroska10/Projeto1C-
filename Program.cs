using System;
using System. Globalization;

class program{
    static void Main (string [] args)
    {   
        double a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        double b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        double c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        double delta = Math.Pow(b, 2) - 4 * a * c;

        if (delta < 0)
        {
        Console.WriteLine("Não há raízes reais para esta equação.");
        }
        else
        {
        double x1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
        double x2 = (-b - Math.Sqrt(delta)) / (2.0 * a);

        Console.WriteLine($"A primeira raiz é {x1.ToString("F2", CultureInfo.InvariantCulture)}");
        Console.WriteLine($"A segunda raiz é {x2.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}