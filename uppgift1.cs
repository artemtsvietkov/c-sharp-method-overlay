using System;

class Program
{
    static void Main()
    {
        Console.Write("Skriv ett tal: ");
        int number = int.Parse(Console.ReadLine());
        int absValue = Absolute(number);
        Console.WriteLine($"Absolutbeloppet är: {absValue}");
    }

    static int Absolute(int number)
    {
        if (number < 0)
        {
            return -number;
        }
        else
        {
            return number;
        }
    }
}
