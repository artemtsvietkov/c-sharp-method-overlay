using System;

class Program
{
    static void Main()
    {
        Console.WriteLine(Absolute(-5));  
        Console.WriteLine(Absolute(10));  
        Console.WriteLine(Absolute(0));   
    }

    static int Absolute(int number)
    {
        return number < 0 ? -number : number;
    }
}
