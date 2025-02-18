using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Välj en figur för att beräkna arean:");
        Console.WriteLine("1 - Cirkel");
        Console.WriteLine("2 - Triangel");
        Console.Write("Ange figurens nummer: ");
        
        string choice = Console.ReadLine();

        if (choice == "1")
        {
            Console.Write("Ange cirkelns radie: ");
            if (double.TryParse(Console.ReadLine(), out double radius) && radius > 0)
            {
                Console.WriteLine($"Cirkelns area: {CalculateArea(radius):F2}");
            }
            else
            {
                Console.WriteLine("Fel! Ange ett positivt tal.");
            }
        }
        else if (choice == "2")
        {
            Console.Write("Ange triangelns baslängd: ");
            if (double.TryParse(Console.ReadLine(), out double baseLength) && baseLength > 0)
            {
                Console.Write("Ange triangelns höjd: ");
                if (double.TryParse(Console.ReadLine(), out double height) && height > 0)
                {
                    Console.WriteLine($"Triangelns area: {CalculateArea(baseLength, height):F2}");
                }
                else
                {
                    Console.WriteLine("Fel! Ange ett positivt tal för höjden.");
                }
            }
            else
            {
                Console.WriteLine("Fel! Ange ett positivt tal för baslängden.");
            }
        }
        else
        {
            Console.WriteLine("Fel! Välj 1 eller 2.");
        }
    }

    static double CalculateArea(double radius)
    {
        return Math.PI * Math.Pow(radius, 2);
    }

    static double CalculateArea(double baseLength, double height)
    {
        return 0.5 * baseLength * height;
    }
}
