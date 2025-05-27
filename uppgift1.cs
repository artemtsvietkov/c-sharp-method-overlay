using System;

class Program
{
    static void Main()
    {
        double[] numbers = { 5.5, -3, 12 };

        foreach (var number in numbers)
        {
            double absValue = Absolute(number);
            Console.WriteLine($"Talet: {number}, Absolutbeloppet är: {absValue}");
        }
    }

    static double Absolute(double number)
    {
        return number < 0 ? -number : number;
    }
}
